using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Business;
using Entities;
using System.Data.Linq.SqlClient;

namespace GUI
{

    public partial class FormCompras : Form
    {
        int defaultGridHeight = 0;
        double ValFrete;
        double ValTot;
        Point defaultBtnNovaCompraLocation;
        Point defaultBtnItensCompraLocation;
        List<Compras> comprasList = new List<Compras>();
        List<Compras> preDataFilterList = new List<Compras>();
        Compras Compras = new Compras();
        Compras_Produtos Produto = new Compras_Produtos();
        List<Compras_Produtos> ProdutosList = new List<Compras_Produtos>();
        public FormCompras()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            defaultGridHeight = dgCompras.Height;
            defaultBtnNovaCompraLocation = btnNovaCompra.Location;
            defaultBtnItensCompraLocation = btnItensCompra.Location;
            Inicializacao();

        }

        private void Inicializacao()
        {
            ValTot = 0;
            ValFrete = 0;
            backgroundWorker1.RunWorkerAsync();
            epCompra.Clear();
            epProduto.Clear();
            gbAddCompra.Hide();
            gbAddProd.Hide();
            btnAddItem.Hide();
            LimparCamposCompra();
            btnNovaCompra.Show();            
            btnItensCompra.Show();
            dgCompras.Height = defaultGridHeight;
            btnNovaCompra.Location = defaultBtnNovaCompraLocation;
            btnItensCompra.Location = defaultBtnItensCompraLocation;
            preDataFilterList.Clear();
            AtualizaContador();


        }
        private void GetCompras()
        {
            comprasList = MetodosBd.GetCompras();
        }

        private void CarregaGrid(List<Compras> compras)
        {
            dgCompras.DefaultCellStyle.ForeColor = Color.Black;
            dgCompras.AutoGenerateColumns = false;
            dgCompras.DataSource = compras;
            dgCompras.Update();
            dgCompras.Refresh();
        }

        private List<VW_ProdutosString> CarregaProdutos()
        {
            return MetodosBd.GetProdutosString();
        }

        private void PopulaProdutos()
        {
            cbProdutos.ValueMember = "IdProduto";
            cbProdutos.DisplayMember = "Produto";
            cbProdutos.DataSource = CarregaProdutos();
        }

        private void LimparCamposCompra()
        {
            cbFornecedor.Text = null;
            dtpDataCompra.Value = DateTime.Now.Date;
            tbNotaFiscal.Clear();
            tbDescCompra.Clear();
            tbQuantidade.Clear();
            tbValorUn.Clear();
            tbValorTotal.Clear();
            tbValorFrete.Clear();
        }

        private void LimparCamposProduto()
        {
            Produto.Quantidade = 0;
            Produto.ValorUnidade = 0;
            Produto.Produto = "";
            tbQuantidade.Clear();
            tbValorUn.Clear();
            tbSubTotal.Clear();
            cbProdutos.Text = null;
            epProduto.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializacao();
        }
        public void AtualizaLista(List<Compras_Produtos> ProdutosList)
        {
            this.ProdutosList = ProdutosList;
            AtualizaContador();
        }
        private void AtualizaContador()
        {
            if (ProdutosList.Any() == false)
            {
                btnContador.Text = "0";
                btnAdicionarCompra.Enabled = false;
            }
            else
            {
                btnContador.Text = Convert.ToString(ProdutosList.Count);
                btnAdicionarCompra.Enabled = true;
            }
        }

        private void GetFornecedores()
        {
            cbFornecedor.ValueMember = "IdFornecedor";
            cbFornecedor.DisplayMember = "Fornecedor";
            cbFornecedor.DataSource = MetodosBd.GetFornecedores();
        }

        private List<Compras> FiltrarDatas(DateTime inicio, DateTime fim)
        {
            List<Compras> compras = new List<Compras>();
            compras = (List<Compras>)dgCompras.DataSource;
            return compras.Where(x => x.DataCompra >= inicio && x.DataCompra <= fim).Select(x => x).ToList();
        }

        private void AlterarBtnFiltroData()
        {

            //Se o icone for um filtro, ele vira uma lata de lixo e aplica o filtro
            if (btnFiltrar.IconChar == FontAwesome.Sharp.IconChar.Filter)
            {
                preDataFilterList = (List<Compras>)dgCompras.DataSource;
                btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
                CarregaGrid(FiltrarDatas(dtpInicial.Value, dtpFinal.Value));
            }
            //Se o icone for uma lata de lixo, ele vira um filtro
            else if (btnFiltrar.IconChar == FontAwesome.Sharp.IconChar.TrashAlt)
            {
                btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
                CarregaGrid(preDataFilterList);
                preDataFilterList.Clear();
            }
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            GetFornecedores();
            btnNovaCompra.Hide();
            btnItensCompra.Hide();
            dgCompras.Height = 200;
            //Muda a localização do grid para a coordenata Y do dgCompras + sua altura
            btnNovaCompra.Location = new Point(btnNovaCompra.Location.X, dgCompras.Location.Y + dgCompras.Height);
            //Muda a localização da group Box para a localização Y do btnNovaCompra
            gbAddCompra.Location = new Point(gbAddCompra.Location.X, btnNovaCompra.Location.Y);
            gbAddCompra.Show();
            btnAddItem.Show();

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            btnAddItem.Hide();
            gbAddProd.Location = btnAddItem.Location;
            gbAddProd.Show();

            PopulaProdutos();
        }

        private void btnFechaItem_Click(object sender, EventArgs e)
        {
            gbAddProd.Hide();
            btnAddItem.Show();
            LimparCamposProduto();
        }


        private void btnAddProdLista_Click(object sender, EventArgs e)
        {

            if (cbProdutos.SelectedValue != null)
            {
                Compras_Produtos produtos = new Compras_Produtos()
                {
                    Id_Produto = (int)cbProdutos.SelectedValue,
                    Produto = cbProdutos.Text,
                    Quantidade = Produto.Quantidade,
                    ValorUnidade = Produto.ValorUnidade,
                    SubTotal = Produto.SubTotal,
                    OfertaAtiva = chbEstado.Checked
                };

                if (produtos.ValidaProduto(cbProdutos, tbQuantidade, tbValorUn, epProduto))
                {
                    gbAddProd.Hide();
                    btnAddItem.Show();
                    ProdutosList.Add(produtos);
                    LimparCamposProduto();
                    AtualizaContador();
                }
            }
            else
            {
                epProduto.SetError(cbProdutos, "Selecione um Produto");
            }

        }

        private void btnAdicionarCompra_Click(object sender, EventArgs e)
        {

            if (cbFornecedor.SelectedValue != null)
            {
                int idCompra = 0;
                Compras compra = new Compras()
                {
                    Id_Fornecedor = (int)cbFornecedor.SelectedValue,
                    DataCompra = dtpDataCompra.Value,
                    Compra = tbDescCompra.Text,
                    ValorTotal = ValTot,
                    ValorFrete = ValFrete,
                    NotaFiscal = tbNotaFiscal.Text
                };

                if (ProdutosList.Any())
                {
                    if (compra.ValidaCompra(dtpDataCompra, tbDescCompra, tbValorTotal, tbValorFrete, tbNotaFiscal, epCompra))
                    {
                        idCompra = MetodosBd.InsertCompra(compra);

                        foreach (Compras_Produtos p in ProdutosList)
                        {
                            p.Id_Compra = idCompra;
                            MetodosBd.InsertCompra_Produto(p);

                        }
                        MessageBox.Show("Compra Adicionada!");
                        btnCancelar_Click(sender, e);
                    }                    
                }

            }
            else
                epCompra.SetError(cbFornecedor, "Selecione um Fornecedor");

        }

        private void dgCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                e.Value = string.Format("{0:C2}", (double)e.Value);
            }
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (tbQuantidade.Text.Trim() == string.Empty)
            {
                Produto.Quantidade = 0;
            }
            else
            {
                Produto.Quantidade = Convert.ToInt32(tbQuantidade.Text);
            }
            Produto.SubTotal = (Produto.ValorUnidade * Produto.Quantidade);
            tbSubTotal.Text = Produto.SubTotal.ToString("C2");
        }

        private void tbValorUn_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                Produto.ValorUnidade = Convert.ToDouble(tbValorUn.Text.Replace("R$ ", ""));                
            }
            catch (Exception)
            {
                Produto.ValorUnidade = 0;
                tbValorUn.Text = Produto.ValorUnidade.ToString("C2");
            }
            Produto.SubTotal = (Produto.ValorUnidade * Produto.Quantidade);
            tbSubTotal.Text = Produto.SubTotal.ToString("C2");
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            FormListaProdutos formLista = new FormListaProdutos(ProdutosList, this);
            formLista.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            GetCompras();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(comprasList);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            switch (cbTipoPesquisa.Text)
            {
                case "Id Compra":
                    CarregaGrid(
                                ((List<Compras>)dgCompras.DataSource).
                                Where(x => x.IdCompra == Convert.ToInt32(tbPesquisa.Text.Trim()))
                                 .Select(x => x).ToList()
                                );
                    break;
                case "Nota Fiscal":
                    CarregaGrid(
                                ((List<Compras>)dgCompras.DataSource).
                                Where(x => x.NotaFiscal == tbPesquisa.Text.Trim())
                                 .Select(x => x).ToList()
                                );
                    break;
                case "Fornecedor":
                    CarregaGrid(
                                ((List<Compras>)dgCompras.DataSource).
                                Where(x => x.Fornecedor.ToUpper().Contains(tbPesquisa.Text.Trim().ToUpper()))
                                 .Select(x => x).ToList()
                                );

                    break;
                case "Valor Total":
                    CarregaGrid(
                                ((List<Compras>)dgCompras.DataSource).
                                Where(x => x.ValorTotal == Convert.ToDouble(tbPesquisa.Text.Trim()))
                                 .Select(x => x).ToList()
                                );
                    break;
                case "Valor Frete":
                    CarregaGrid(
                                ((List<Compras>)dgCompras.DataSource).
                                Where(x => x.ValorFrete == Convert.ToDouble(tbPesquisa.Text.Trim()))
                                 .Select(x => x).ToList()
                                );
                    break;
                default:
                    MessageBox.Show("Selecione um dos intes para pesquisar!");
                    break;
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            CarregaGrid(comprasList);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            cbTipoPesquisa.Text = null;
            tbPesquisa.Clear();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            AlterarBtnFiltroData();
        }

        private void tbPesquisa_Enter(object sender, EventArgs e)
        {
            tbPesquisa.SelectAll();
        }

        private void tbValorTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                ValTot = Convert.ToDouble(tbValorTotal.Text.Replace("R$ ", ""));
                tbValorTotal.Text = ValTot.ToString("C2");
            }
            catch (Exception)
            {
                ValTot = 0;
                tbValorTotal.Text = ValTot.ToString("C2");
            }
        }

        private void tbValorFrete_Leave(object sender, EventArgs e)
        {
            try
            {
                ValFrete = Convert.ToDouble(tbValorFrete.Text.Replace("R$ ", ""));
                tbValorFrete.Text = ValFrete.ToString("C2");
            }
            catch (Exception)
            {
                ValFrete = 0;
                tbValorFrete.Text = ValFrete.ToString("C2");
            }

        }

        private void btnItensCompra_Click(object sender, EventArgs e)
        {
            Compras = (Compras)dgCompras.SelectedRows[0].DataBoundItem;
            FormListaProdutos frmListaProd = new FormListaProdutos(Compras);
            frmListaProd.Show();
        }
    }
}
