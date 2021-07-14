using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entities;

namespace GUI
{
    public partial class FormPagamento : Form
    {
        FormNovaVenda frmNovaVenda = new FormNovaVenda();
        List<Produtos_Venda> produtos = new List<Produtos_Venda>();
        List<Clientes> clientesList = new List<Clientes>();
        Clientes Cliente = new Clientes();
        List<Vendedores> vendedoresList = new List<Vendedores>();
        double valTot;
        public FormPagamento()
        {
            InitializeComponent();
        }

        public FormPagamento(List<Produtos_Venda> produtos, FormNovaVenda frmNovaVenda)
        {
            this.produtos = produtos;
            this.frmNovaVenda = frmNovaVenda;
            InitializeComponent();
            Inicializacao();
        }
        private void Inicializacao()
        {
            backgroundWorker1.RunWorkerAsync();
            PreencheListView(produtos);
            tbTotalAPagar.Text = valTot.ToString("C2");
        }
        private void ConfiguraListView()
        {
            lvProdutos.Columns[0].Width = 82;
            lvProdutos.Columns[1].Width = 266;
            lvProdutos.Columns[2].Width = 107;
            lvProdutos.Columns[3].Width = 66;
            lvProdutos.Columns[4].Width = 91;
        }
        private void PreencheListView(List<Produtos_Venda> produtos)
        {
            ConfiguraListView();
            //Adiciona uma linha no ListView para cada objeto da lista
            foreach (Produtos_Venda p in produtos)
            {
                //Faz o somatório total dos valores
                valTot += p.SubTotal;

                string[] pv = {p.Id_Produto.ToString(), p.Produto, p.ValorVenda.ToString("C2"),
                    p.Quantidade.ToString(), p.SubTotal.ToString("C2")};

                var lvItens = new ListViewItem(pv);
                lvProdutos.Items.Add(lvItens);
            }
            //Add uma linha em branco
            var blankLine = new ListViewItem("");
            lvProdutos.Items.Add(blankLine);

            //Add o Somatorio total dos valores
            string[] total = { "", "", "", "Total :", valTot.ToString("C2") };
            var lvTotal = new ListViewItem(total);
            lvTotal.ForeColor = Color.Red;
            lvProdutos.Items.Add(lvTotal);
        }
        private void ConfiguraGrid()
        {
            dgClientes.AutoGenerateColumns = false;
            dgClientes.Columns[0].Width = 65;
            dgClientes.Columns[1].Width = 230;
            dgClientes.Columns[2].Width = 85;
            dgClientes.Columns[3].Width = 135;
            dgClientes.Columns[4].Width = 230;
            dgClientes.Columns[5].Width = 130;
            dgClientes.Columns[6].Width = 130;

        }
        private void CarregaGrid(List<Clientes> clientesList)
        {
            ConfiguraGrid();
            dgClientes.DataSource = clientesList;
            dgClientes.Refresh();
            dgClientes.Update();
        }

        private void CarregaVendedores(List<Vendedores> vendedoresList)
        {
            cbVendedores.ValueMember = "IdVendedor";
            cbVendedores.DisplayMember = "Nome";
            cbVendedores.DataSource = vendedoresList;
            cbVendedores.Text = null;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vendedoresList = MetodosBd.GetVendedores();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaVendedores(vendedoresList);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Pega os Clientes do Banco de Dados
            clientesList = MetodosBd.GetClientes();

            //Se o Texo não estiver em Branco e não conter Numeros
            if (tbPesq.Text.All(char.IsDigit) && tbPesq.Text.Trim().Length > 0)
            {
                //Se o tamanho da pesquisa for > 8, Pesquisa por numeros de telefone
                if (tbPesq.Text.Trim().Length >= 8)
                {
                    CarregaGrid(
                        clientesList.Where(x => x.Telefone.Contains(tbPesq.Text)
                        ||
                        x.WhatsApp.Contains(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                }
                //Se não, pesquisa por Id do Cliente
                else
                {
                    CarregaGrid(
                        clientesList.Where(x => x.IdCliente == Convert.ToInt32(tbPesq.Text.Trim()))
                        .Select(x => x).ToList()
                        );
                }
            }
            //Se tiver @ na string, pesquisa por email
            if (tbPesq.Text.Trim().Contains("@"))
            {
                CarregaGrid(
                        clientesList.Where(x => x.Email.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
            //Se só tiver letras na string, pesquisa pelo nome
            if (tbPesq.Text.Trim().Replace(" ", "").All(char.IsLetter))
            {
                CarregaGrid(
                        clientesList.Where(x => x.Nome.ToUpper().Contains(tbPesq.Text.ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
        }
        private void SelecionaCliente(bool selecionado)
        {
            //se selecionado == True então pega o cliente selecionado,
            //fecha o datagridview e reposiciona o panelPagamento no seu lugar
            if (selecionado == true)
            {
                Cliente = null;
                Cliente = (Clientes)dgClientes.SelectedRows[0].DataBoundItem;
                dgClientes.Hide();
                panelPagamento.Location = dgClientes.Location;
                tbPesq.Text = Cliente.Nome;
                tbPesq.Enabled = false;
                btnPesquisar.Hide();
                btnVoltarPesq.Location = btnPesquisar.Location;
                toolTip1.SetToolTip(btnFinalizarPag, "");
                btnFinalizarPag.Enabled = true;
            }
            //Volta os Controles no Lugar inicial e limpa o grid
            else
            {
                dgClientes.DataSource = null;
                dgClientes.Show();
                panelPagamento.Location = new Point(dgClientes.Location.X, dgClientes.Location.Y + dgClientes.Height + 5);
                tbPesq.Clear();
                tbPesq.Enabled = true;
                btnPesquisar.Show();
                btnVoltarPesq.Location = new Point(btnPesquisar.Location.X + btnPesquisar.Width, btnPesquisar.Location.Y);
                toolTip1.SetToolTip(btnFinalizarPag, "Selecione um Cliente para Finalizar a Venda");
                btnFinalizarPag.Enabled = false;
            }
        }

        private bool ValidaObjs(Vendas venda, Pagamentos pagamento)
        {
            List<bool> validadoList = new List<bool>();
            bool validado = true;
            validadoList.Add(pagamento.ValidaPag(cbTipoPag, ep1));
            validadoList.Add(venda.ValidaVenda(dtpDataVenda, cbVendedores, cbTipoComp, tbNumComp, cbTipoVenda, ep1));
            foreach (bool val in validadoList)
            {
                if (val == false)
                {
                    validado = false;
                }
            }
            return validado;
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            if (dgClientes.Visible == true)
            {
                tbPesq.Clear();
                dgClientes.DataSource = null;
            }
            if (dgClientes.Visible == false)
            {
                SelecionaCliente(false);
            }
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaCliente(true);
        }

        private void tbDesconto_TextChanged(object sender, EventArgs e)
        {
            double desconto = 0;
            try
            {
                desconto = Convert.ToDouble(tbDesconto.Text.Replace(" %", ""));
                tbTotalAPagar.Text = (valTot - (valTot * (desconto / 100))).ToString("C2");
            }
            catch (Exception)
            {
                tbTotalAPagar.Text = valTot.ToString("C2");
                tbDesconto.Text = " %";
            }
        }

        private void tbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsSymbol(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void tbDesconto_Click(object sender, EventArgs e)
        {
            tbDesconto.Select(0, 0);
        }

        private void cbTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPag.Text == "Credito")
            {
                pnParcelas.Show();
            }
            else
            {
                pnParcelas.Hide();
                nudNumParc.Value = 1;
            }
        }

        private void btnFinalizarPag_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas
            {
                Id_Cliente = Cliente.IdCliente,
                Id_Vendedor = (cbVendedores.SelectedValue == null ? 0 : (int)cbVendedores.SelectedValue),
                DataVenda = dtpDataVenda.Value,
                TipoComprovante = cbTipoComp.Text.Trim(),
                NumeroComprovante = tbNumComp.Text.Trim(),
                Total = valTot,
                TotalPago = Convert.ToDouble(tbTotalAPagar.Text.Replace("R$ ", "")),
                TipoVenda = cbTipoVenda.Text
            };

            Pagamentos pagamento = new Pagamentos
            {
                DataPag = dtpDataVenda.Value,
                TipoPag = cbTipoPag.Text,
                Valor = Convert.ToDouble(tbTotalAPagar.Text.Replace("R$", "")),
                Parcelas = Convert.ToInt32(nudNumParc.Value),
                Categoria = "Venda"
            };
            if (ValidaObjs(venda, pagamento))
            {      
                try
                {
                    
                    MetodosVenda.InsertNovaVenda(produtos, venda, pagamento);
                    MessageBox.Show("Venda Finalizada");
                    frmNovaVenda.LimpaCarrinho();
                    this.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Não foi possivel Concluir a Venda. " + erro);
                }
                
            }


        }
    }
}
