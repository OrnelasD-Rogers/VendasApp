using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Business;

namespace GUI
{

    public partial class FormListaProdutos : Form
    {
        List<Compras_Produtos> ProdutosList = new List<Compras_Produtos>();
        List<Produtos_Venda> ProdutosVendaList = new List<Produtos_Venda>();
        FormCompras FormCompras = new FormCompras();
        FormNovaVenda formNovaVenda = new FormNovaVenda();
        List<VW_ProdutosVenda> VwProdutosList = new List<VW_ProdutosVenda>();
        int Qtd { get; set; }
        double ValorUn { get; set; }
        double SubTot { get; set; }
        int Index { get; set; }
        
        public FormListaProdutos()
        {
            InitializeComponent();
        }

        //Chama o Form através do FormVendas
        public FormListaProdutos(int idVenda)
        {
            InitializeComponent();
            InicializacaoFormVendas();
            ConfiguraGridProdutosVendas();
            CarregaGridProdutosVenda(idVenda);
            
        }

        //Chama o Form através do FormCompras mostrando os produtos da venda já efetuada
        public FormListaProdutos(Compras compras)
        {
            InitializeComponent();
            InicializacaoFormVendas();
            ConfiguraGridProdutosCompras();
            CarregaGrid(MetodosBd.GetProdutosCompra(compras.IdCompra));

        }

        //Chama o Form Através do FormCompras mostrando o carrinho
        public FormListaProdutos(List<Compras_Produtos> ProdutosList, FormCompras FormCompras)
        {
            this.ProdutosList = ProdutosList;
            this.FormCompras = FormCompras;
            InitializeComponent();
            CarregaGrid(ProdutosList);
        }
        //Chama o Form Através do FormNovaVenda
        public FormListaProdutos(List<Produtos_Venda> ProdutosVendaList, FormNovaVenda formNovaVenda)
        {
            this.ProdutosVendaList = ProdutosVendaList;
            this.formNovaVenda = formNovaVenda;
            InitializeComponent();
            ConfiguraGridProdutosVendas();
            CarregaGrid(ProdutosVendaList);
            tbValUn.Enabled = false;
        }



        private void CarregaGrid(object Lista)
        {
            dgItens.DataSource = null;
            dgItens.AutoGenerateColumns = false;
            dgItens.DataSource = Lista;
            dgItens.Update();
            dgItens.Refresh();
        }

        private void InicializacaoFormVendas()
        {
            lblProduto.Hide();
            lblQtd.Hide();
            lblValUn.Hide();
            lblSubTotal.Hide();
            tbProduto.Hide();
            tbQtd.Hide();
            tbValUn.Hide();
            tbSubTotal.Hide();
            btnEditarProduto.Hide();
            btnExcluirProduto.Hide();
        }

        private void CarregaGridProdutosVenda(int idVenda)
        {
            VwProdutosList = MetodosBd.GetProdutosVendaById(idVenda);
            dgItens.DataSource = null;
            dgItens.AutoGenerateColumns = false;
            dgItens.DataSource = VwProdutosList;
            dgItens.Update();
            dgItens.Refresh();
            double total = 0;
            VwProdutosList.ForEach(x => total += x.SubTotal);
            tbTotal.Text = total.ToString("C2");
            lblTotal.Show();
            tbTotal.Show();
        }

        private void ConfiguraGridProdutosVendas()
        {
            dgItens.Columns[0].Name = "Id Produto";
            dgItens.Columns[0].Width = 100;
            dgItens.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgItens.Columns[0].DataPropertyName = "Id_Produto";

            dgItens.Columns[1].Name = "Produto";
            dgItens.Columns[1].Width = 280;
            dgItens.Columns[1].DataPropertyName = "Produto";

            dgItens.Columns[2].Name = "Quantidade";
            dgItens.Columns[2].Width = 100;
            dgItens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgItens.Columns[2].DataPropertyName = "Quantidade";

            dgItens.Columns[3].Name = "Valor Venda";
            dgItens.Columns[3].Width = 130;
            dgItens.Columns[3].DataPropertyName = "ValorVenda";

            dgItens.Columns[4].Name = "Sub Total";
            dgItens.Columns[4].Width = 120;
            dgItens.Columns[4].DataPropertyName = "SubTotal";


        }

        private void ConfiguraGridProdutosCompras()
        {
            dgItens.Columns[0].Name = "Id Produto";
            dgItens.Columns[0].Width = 100;
            dgItens.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgItens.Columns[0].DataPropertyName = "Id_Produto";

            dgItens.Columns[1].Name = "Produto";
            dgItens.Columns[1].Width = 280;
            dgItens.Columns[1].DataPropertyName = "Produto";

            dgItens.Columns[2].Name = "Quantidade";
            dgItens.Columns[2].Width = 100;
            dgItens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgItens.Columns[2].DataPropertyName = "Quantidade";

            dgItens.Columns[3].Name = "Valor Unidade";
            dgItens.Columns[3].Width = 130;
            dgItens.Columns[3].DataPropertyName = "ValorUnidade";

            dgItens.Columns[4].Name = "Sub Total";
            dgItens.Columns[4].Width = 120;
            dgItens.Columns[4].DataPropertyName = "SubTotal";

        }



        private void AlterarBtnEditarProduto(bool yesNo)
        {
            if (yesNo)
            {
                btnEditarProduto.Text = "Salvar Alterações";
                btnEditarProduto.IconChar = FontAwesome.Sharp.IconChar.Save;
                tbValUn.Enabled = true;
                tbQtd.Enabled = true;
                btnExcluirProduto.Enabled = false;
                ValorUn = Convert.ToDouble(tbValUn.Text.Replace("R$ ", ""));
                Qtd = Convert.ToInt32(tbQtd.Text);
                SubTot = ValorUn * Qtd;
            }
            if (yesNo == false)
            {
                btnEditarProduto.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnEditarProduto.Text = "Editar Produto";
                ProdutosList[Index].Quantidade = Convert.ToInt32(tbQtd.Text);
                ProdutosList[Index].ValorUnidade = Convert.ToDouble(tbValUn.Text.Replace("R$ ", ""));
                ProdutosList[Index].SubTotal = Convert.ToDouble(tbSubTotal.Text.Replace("R$ ", ""));
                tbValUn.Enabled = false;
                tbQtd.Enabled = false;
                btnExcluirProduto.Enabled = true;
            }

        }
        private void dgItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                e.Value = string.Format("{0:C2}", (double)e.Value);
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (tbQtd.Text != "")
            {
                if (btnEditarProduto.Text == "Editar Produto")
                {

                    AlterarBtnEditarProduto(true);

                }
                else
                {
                    AlterarBtnEditarProduto(false);
                    CarregaGrid(ProdutosList);

                }

            }

        }

        private void dgItens_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = dgItens.SelectedRows[0].Index;
            tbProduto.Text = Convert.ToString(dgItens.Rows[Index].Cells[1].Value);
            tbQtd.Text = Convert.ToString(dgItens.Rows[Index].Cells[2].Value);
            tbValUn.Text = Convert.ToString(dgItens.Rows[Index].Cells[3].FormattedValue);
            tbSubTotal.Text = Convert.ToString(dgItens.Rows[Index].Cells[4].FormattedValue);

        }

        private void tbQtd_TextChanged(object sender, EventArgs e)
        {

            if (tbQtd.Text != "")
            {
                Qtd = Convert.ToInt32(tbQtd.Text);
                SubTot = ValorUn * Qtd;
                tbSubTotal.Text = SubTot.ToString("C2");
            }

        }

        private void tbValUn_TextChanged(object sender, EventArgs e)
        {
            if (tbQtd.Text != "")
            {
                ValorUn = Convert.ToDouble(tbValUn.Text.Replace("R$ ", ""));
                SubTot = ValorUn * Qtd;
                tbSubTotal.Text = SubTot.ToString("C2");
            }
        }

        private void tbValUn_Leave(object sender, EventArgs e)
        {
            tbValUn.Text = ValorUn.ToString("C2");
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja Excluir o Item Selecionado?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                ProdutosList.RemoveAt(Index);
                CarregaGrid(ProdutosList);
            }
        }

        private void FormListaProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCompras.AtualizaLista(ProdutosList);
        }

    }
}
