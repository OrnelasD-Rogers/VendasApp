using Business;
using Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNovaVenda : Form
    {
        List<Clientes> clientesList = new List<Clientes>();
        List<VW_ProdutoGrid> ProdList = new List<VW_ProdutoGrid>();
        List<Produtos_Venda> CarrinhoList = new List<Produtos_Venda>();
        VW_ProdutoGrid Prod = new VW_ProdutoGrid();
        public FormNovaVenda()
        {
            InitializeComponent();            
            AtualizaContador();
            backgroundWorker1.RunWorkerAsync();
        }
        //Limpa as TextBoxes
        private void LimpaCamposProd()
        {
            tbProduto.Clear();
            tbCategoria.Clear();
            tbValorVenda.Clear();
            tbTipo.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
            tbDescricao.Clear();
            tbQuantidade.Clear();
            errorProvider1.Clear();
        }
        //Limpa o carrinho
        public void LimpaCarrinho()
        {
            backgroundWorker1.RunWorkerAsync();
            CarrinhoList.Clear();
            AtualizaContador();            
        }
        //Carrega o Grid com uma Lista
        private void CarregaGrid(List<VW_ProdutoGrid> ProdList)
        {
            dgProdutos.AutoGenerateColumns = false;
            dgProdutos.DataSource = ProdList;
            dgProdutos.Update();
            dgProdutos.Refresh();
        }

        private void AtualizaContador()
        {
            if (CarrinhoList.Any() == false)
            {
                btnContador.Text = "0";
                btnAdicionarVenda.Enabled = false;
            }
            else
            { 
                btnContador.Text = Convert.ToString(CarrinhoList.Count);
                btnAdicionarVenda.Enabled = true;
            }
                
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid(
                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                    .Where(x => x.Produto.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                    .Select(x => x).ToList()
                    );
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            CarregaGrid(ProdList);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (tbProduto.Text != "")
            {
                if (tbQuantidade.Text.Trim() != "")
                {
                    int qtd = Convert.ToInt32(tbQuantidade.Text.Trim());
                    if ((Prod.Estoque - qtd) > Prod.EstoqueMin )
                    {
                        CarrinhoList.Add(new Produtos_Venda
                        {
                            Id_Produto = Prod.IdProduto,
                            Produto = Prod.Produto,
                            Quantidade = qtd,
                            ValorVenda = Prod.ValorVenda,
                            SubTotal = Convert.ToDouble(Convert.ToInt32(tbQuantidade.Text.Trim()) * Prod.ValorVenda)
                        });
                        errorProvider1.SetError(tbQuantidade, "");
                        LimpaCamposProd();
                        AtualizaContador();                          
                    }
                    else
                    {
                        errorProvider1.SetError(tbQuantidade, $"A quantidade excede o limite mínimo de Estoque do Item ({Prod.EstoqueMin.ToString()} un) ");
                    }
                }
                else
                    errorProvider1.SetError(tbQuantidade, "Digite a quantidade a ser vendida");
            }
            else
                MessageBox.Show("Escolha um dos Produtos da Lista ou Adicione um Novo!");
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            FormListaProdutos formListaProdutos = new FormListaProdutos(CarrinhoList, this);
            formListaProdutos.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProdList = MetodosBd.GetProdutosView();            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CarregaGrid(ProdList);            
        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = (Convert.ToInt64(e.Value)).ToString("C2");
            }
        }

        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            FormPagamento frmPagamento = new FormPagamento(CarrinhoList, this);
            frmPagamento.Show();
        }

        private void dgProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Prod = null;
            Prod = (VW_ProdutoGrid)dgProdutos.SelectedRows[0].DataBoundItem;
            LimpaCamposProd();
            //Atribui os Valores do Objeto Prod nas TextBoxes
            {
                tbProduto.Text = Prod.Produto;
                tbCategoria.Text = Prod.Categoria;
                tbValorVenda.Text = Prod.ValorVenda.ToString("C2");
                tbTipo.Text = Prod.Tipo;
                tbMarca.Text = Prod.Marca;
                tbModelo.Text = Prod.Modelo;
                tbDescricao.Text = Prod.Descricao;
            }
        }
    }
}
