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
using FontAwesome.Sharp;
using Entities;

namespace GUI
{
    public partial class FormProdutos : Form
    {
        IconButton currentIcon = new IconButton();
        List<VW_ProdutoGrid> ProdutosList = new List<VW_ProdutoGrid>();
        VW_ProdutoGrid p = new VW_ProdutoGrid();
        List<Categorias> CategoriasList = new List<Categorias>();
        List<Tipos> TiposList = new List<Tipos>();
        List<Marcas> MarcasList = new List<Marcas>();
        List<Modelos> ModelosList = new List<Modelos>();
        int defaultGridHeight = 0;
        List<VW_ProdutoGrid> preFilterList = new List<VW_ProdutoGrid>();

        int Index { get; set; }
        public FormProdutos()
        {
            InitializeComponent();            
            defaultGridHeight = dgProdutos.Height;
            Inicializacao();

        }

        private void Inicializacao()
        {
            LimpaCamposNovoProd();
            gbAddProduto.Hide();
            lblProdAtivo.Hide();
            cbProdutoAtivo.Hide();
            dgProdutos.Height = defaultGridHeight;
            gbBotoes.Location = new Point(dgProdutos.Location.X, dgProdutos.Location.Y + defaultGridHeight);
        }

        private void ReiniciarBtnAddNovoProd()
        {
            btnAddNovoProd.Text = "Adicionar Produto";
            btnAddNovoProd.IconChar = currentIcon.IconChar;
        }

        private void LimpaCamposNovoProd()
        {
            tbProduto.Clear();
            cbCategoria.Text = "";
            tbValorVenda.Text = "";
            cbTipo.Text = "";
            cbMarca.Text = "";
            cbModelo.Text = "";
            tbDescricao.Clear();
            errorProvider1.Clear();
        }

        private void AtualizaGrid(List<VW_ProdutoGrid> ProdList)
        {
            dgProdutos.DataSource = null;
            dgProdutos.AutoGenerateColumns = false;
            dgProdutos.DataSource = ProdList;
            dgProdutos.Update();
            dgProdutos.Refresh();
        }

        private bool ValidaCaixas()
        {
            List<bool> verificacao = new List<bool>();
            bool validado = true;
            //Verifica se a caixa do produto está vazia
            {
                if (tbProduto.Text.Trim() == "")
                {
                    errorProvider1.SetError(tbProduto, "Digite o nome do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(tbProduto, "");
                }
            }

            //Verifica se a combobox categoria está vazia
            {
                if (cbCategoria.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbCategoria, "Entre com a categoria do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(cbCategoria, "");
                }
            }

            //Verifica se a combobox Tipo está vazia
            {
                if (cbTipo.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbTipo, "Entre com o tipo do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(cbTipo, "");
                }
            }

            //Verifica se a combobox Marca está vazia
            {
                if (cbMarca.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbMarca, "Entre com a marca do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(cbMarca, "");
                }
            }

            //Verifica se a combobox Marca está vazia
            {
                if (cbMarca.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbMarca, "Entre com a marca do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(cbMarca, "");
                }
            }

            //Verifica se a combobox Modelo está vazia
            {
                if (cbModelo.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbModelo, "Entre com o modelo do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(cbModelo, "");
                }
            }

            //Verifica se a TextBox ValorVenda está vazia
            {
                if (tbValorVenda.Text.Trim().Replace("R$ ","") == "")
                {
                    errorProvider1.SetError(tbValorVenda, "Digite o valor do produto");
                    verificacao.Add(false);
                }
                else
                {
                    errorProvider1.SetError(tbValorVenda, "");
                }
            }

            foreach (bool item in verificacao)
            {
                if (item == false)
                {
                    validado = false;
                }
            }
            return validado;
        }
        private void CadastraNovoProduto()
        {
            //Crio as Variaveis Auxiliares
            int idCat = 0;
            int idTipo = 0;
            int idMarca = 0;
            int idModelo = 0;
            //Pego os itens de cada ComboBox
            List<Categorias> CategoriasList = new List<Categorias>((List<Categorias>)cbCategoria.DataSource);
            List<Tipos> TiposList = new List<Tipos>((List<Tipos>)cbTipo.DataSource);
            List<Marcas> MarcasList = new List<Marcas>((List<Marcas>)cbMarca.DataSource);
            List<Modelos> ModelosList = new List<Modelos>((List<Modelos>)cbModelo.DataSource);

            //Verifico se já existe este item na lista
            bool catExistente = CategoriasList.Where(x => x.Categoria.ToUpper() == cbCategoria.Text.ToUpper()).Select(x => x).Any();
            bool tipoExistente = TiposList.Where(x => x.Tipo.ToUpper() == cbTipo.Text.ToUpper()).Select(x => x).Any();
            bool marcaExistente = MarcasList.Where(x => x.Marca.ToUpper() == cbMarca.Text.ToUpper()).Select(x => x).Any();
            bool modeloExistente = ModelosList.Where(x => x.Modelo.ToUpper() == cbModelo.Text.ToUpper()).Select(x => x).Any();

            //Se a Categoria não existe, ela é criada
            {
                if (catExistente == false)
                {
                    idCat = MetodosBd.InsertCategoria(new Categorias { Categoria = cbCategoria.Text.Trim() });
                }
                else
                {
                    idCat = (int)cbCategoria.SelectedValue;
                }
            }
            //Se o tipo não existir, ele é criado
            {
                if (tipoExistente == false)
                {
                    idTipo = MetodosBd.InsertTipo(new Tipos { Tipo = cbTipo.Text.Trim() });
                }
                else
                {
                    idTipo = (int)cbTipo.SelectedValue;
                }
            }
            //Se a marca não existir, ela é criada
            {
                if (marcaExistente == false)
                {
                    idMarca = MetodosBd.InsertMarca(new Marcas { Marca = cbMarca.Text.Trim() });
                }
                else
                {
                    idMarca = (int)cbMarca.SelectedValue;
                }
            }

            //Se o modelo não existir, ele é criado
            {
                if (modeloExistente == false)
                {
                    idModelo = MetodosBd.InsertModelo(new Modelos { Modelo = cbModelo.Text.Trim() });
                }
                else
                {
                    idModelo = (int)cbModelo.SelectedValue;
                }
            }
            //Cadastra o Produto
            MetodosBd.InsertProduto(new Produtos
            {
                Id_Categoria = idCat,
                Id_Tipo = idTipo,
                Id_Marca = idMarca,
                Id_Modelo = idModelo,
                Produto = tbProduto.Text.Trim(),
                Descricao = tbDescricao.Text.Trim(),
                ValorCompra = 0,
                ValorVenda = Convert.ToDouble(tbValorVenda.Text.Replace("R$ ", "")),
                Estado = (cbProdutoAtivo.Text == "Sim" ? true : false),
                Estoque = 0,
                EstoqueMin = Convert.ToInt32(nudEstoqueMin.Value)
            });

        }


        private void BloqueiaBotoes(IconButton button)
        {
            switch (button.Name)
            {
                case "btnNovoProduto":
                    btnNovoProduto.Enabled = false;
                    btnEditarProduto.Enabled = false;
                    btnExluirProduto.Enabled = false;
                    lblProdAtivo.Hide();
                    cbProdutoAtivo.Hide();
                    break;
                case "btnEditarProduto":
                    btnNovoProduto.Enabled = false;
                    btnExluirProduto.Enabled = false;
                    btnLimparProduto.Visible = false;
                    break;
                default:
                    btnNovoProduto.Enabled = true;
                    btnEditarProduto.Enabled = true;
                    btnExluirProduto.Enabled = true;
                    btnLimparProduto.Visible = true;
                    break;
            }
        }

        private void RealocaCampos()
        {
            dgProdutos.Height = 200;
            gbBotoes.Location = new Point(dgProdutos.Location.X, dgProdutos.Location.Y + dgProdutos.Height);
            gbAddProduto.Location = new Point(dgProdutos.Location.X, gbBotoes.Location.Y + gbBotoes.Height);
        }

        void EditarProduto()
        {
                  
            p = (VW_ProdutoGrid)dgProdutos.SelectedRows[0].DataBoundItem;
            tbProduto.Text = p.Produto;
            cbCategoria.Text = p.Categoria;
            cbTipo.Text = p.Tipo;
            cbMarca.Text = p.Marca;
            cbModelo.Text = p.Modelo;
            tbDescricao.Text = p.Descricao;
            tbValorVenda.Text = p.ValorVenda.ToString("C2");
            cbProdutoAtivo.SelectedItem = (p.Estado == true ? "Sim" : "Não");
            nudEstoqueMin.Value = p.EstoqueMin;
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            RealocaCampos();
            gbAddProduto.Show();
            BloqueiaBotoes((IconButton)sender);

        }

        private void ConfiguraComboBoxes()
        {
            cbCategoria.DataSource = null;
            cbCategoria.DisplayMember = "Categoria";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.DataSource = CategoriasList;
            cbCategoria.SelectedItem = null;

            cbTipo.DataSource = null;
            cbTipo.DisplayMember = "Tipo";
            cbTipo.ValueMember = "IdTipo";
            cbTipo.DataSource = TiposList;
            cbTipo.SelectedItem = null;

            cbMarca.DataSource = null;
            cbMarca.DisplayMember = "Marca";
            cbMarca.ValueMember = "IdMarca";
            cbMarca.DataSource = MarcasList;
            cbMarca.SelectedItem = null;

            cbModelo.DataSource = null;
            cbModelo.DisplayMember = "Modelo";
            cbModelo.ValueMember = "IdModelo";
            cbModelo.DataSource = ModelosList;
            cbModelo.SelectedItem = null;
        }
        private void CarregaListaCombos()
        {
            CategoriasList = MetodosBd.GetCategorias();
            TiposList = MetodosBd.GetTipos();
            MarcasList = MetodosBd.GetMarcas();
            ModelosList = MetodosBd.GetModelos();
        }

        private void CarregaGrid()
        {
            ProdutosList = MetodosBd.GetProdutosView();
        }

        private void AtualizarDados(Produtos p)
        {

            try
            {
                MetodosBd.UpdateProduto(p);
                MessageBox.Show("Dados Atualizados!");
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (btnAddNovoProd.Text)
            {
                case "Salvar Alterações":
                    DialogResult res = MessageBox.Show("As alterações serão perdidas. Deseja fechar esta pagina mesmo assim?", "", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        ReiniciarBtnAddNovoProd();
                        Inicializacao();
                        LimpaCamposNovoProd();
                        BloqueiaBotoes((IconButton)sender);
                    }
                    break;
                default:
                    Inicializacao();
                    LimpaCamposNovoProd();
                    BloqueiaBotoes((IconButton)sender);
                    break;
            }

        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            LimpaCamposNovoProd();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows[0].Cells != null)
            {
                RealocaCampos();
                gbAddProduto.Show();
                BloqueiaBotoes((IconButton)sender);
                btnAddNovoProd.Text = "Salvar Alterações";
                currentIcon.IconChar = btnAddNovoProd.IconChar;
                btnAddNovoProd.IconChar = FontAwesome.Sharp.IconChar.Check;
                lblProdAtivo.Show();
                cbProdutoAtivo.Show();
                cbProdutoAtivo.SelectionStart = 0;
                EditarProduto();
            }

        }


        private void btnAddNovoProd_Click(object sender, EventArgs e)
        {
            if (btnAddNovoProd.Text == "Salvar Alterações")
            {
                if (ValidaCaixas())
                {
                    ReiniciarBtnAddNovoProd();
                    AtualizarDados(new Produtos
                    {
                        IdProduto = p.IdProduto,
                        Id_Categoria = (int)cbCategoria.SelectedValue,
                        Id_Tipo = (int)cbTipo.SelectedValue,
                        Id_Marca = (int)cbMarca.SelectedValue,
                        Id_Modelo = (int)cbModelo.SelectedValue,
                        Produto = tbProduto.Text.Trim(),
                        Descricao = tbDescricao.Text.Trim(),
                        ValorVenda = Convert.ToDouble(tbValorVenda.Text.Replace("R$ ", "")),
                        Estado = (cbProdutoAtivo.Text == "Sim" ? true : false),
                        EstoqueMin = Convert.ToInt32(nudEstoqueMin.Value)
                    });
                    BloqueiaBotoes((IconButton)sender);
                    Inicializacao();
                    CarregaGrid();
                    AtualizaGrid(ProdutosList);
                }
            }
            else if (btnAddNovoProd.Text == "Adicionar Produto")
            {
                if (ValidaCaixas())
                {
                    CadastraNovoProduto();
                    CarregaListaCombos();
                    ConfiguraComboBoxes();
                    BloqueiaBotoes((IconButton)sender);
                    Inicializacao();
                    CarregaGrid();
                    AtualizaGrid(ProdutosList);
                }
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CarregaGrid();
            CarregaListaCombos();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AtualizaGrid(ProdutosList);
            ConfiguraComboBoxes();
        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = Convert.ToDouble(e.Value).ToString("C2");
            }
            if (e.ColumnIndex == 8)
            {
                e.Value = Convert.ToDouble(e.Value).ToString("C2");
            }
            if (e.ColumnIndex == 11)
            {
                if (Convert.ToBoolean(e.Value))
                {
                    e.Value = "Ativo";
                }
                else
                {
                    e.Value = "Inativo";
                }
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void tbValorVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                tbValorVenda.Text = tbValorVenda.Text.Replace("R$ ", "");
                tbValorVenda.Text = Convert.ToDouble(tbValorVenda.Text).ToString("C2");
            }
            catch (Exception) {}
            
        }

        private void btnExluirProduto_Click(object sender, EventArgs e)
        {
            if (dgProdutos.SelectedRows[0] != null)
            {
                DialogResult res = MessageBox.Show("Deseja Deletar o Item Selecionado?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    int idProd = ((VW_ProdutoGrid)dgProdutos.SelectedRows[0].DataBoundItem).IdProduto;
                    MetodosBd.DeleteProduto(idProd);
                    CarregaGrid();
                    AtualizaGrid(ProdutosList);
                }
            }
        }
        private void AlterarBtnFiltro()
        {
            //Se o icone for um filtro, ele vira uma lata de lixo e aplica o filtro
            if (btnFiltrar.IconChar == IconChar.Filter)
            {
                preFilterList = (List<VW_ProdutoGrid>)dgProdutos.DataSource;
                btnFiltrar.IconChar = IconChar.TrashAlt;                
            }
            //Se o icone for uma lata de lixo, ele vira um filtro
            else if (btnFiltrar.IconChar == IconChar.TrashAlt)
            {
                //Limpa os textos das combo boxes
                {

                    cbFiltro.Text = "";
                    cbTipoFiltro.Text = "";
                }
                btnFiltrar.IconChar = IconChar.Filter;
                InicializacaoFiltro();
                AtualizaGrid(preFilterList);                
            }
        }
        private void InicializacaoFiltro()
        {
            //Limpa a cbFiltro
            {
                cbFiltro.DataSource = null;
                cbFiltro.Items.Clear();
            }
            //Muda a Visibilidade dos controles do Filtro
            {
                cbFiltro.Visible = false;
                tbValFiltroIni.Visible = false;
                tbValFiltroFin.Visible = false;
            }
           
            //Coloca os controles nas posições padrão
            {
                btnFiltrar.Location = new Point(325, 12);
            }
        }

        private void cbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializacaoFiltro();
            int s = 10;
            switch (cbTipoFiltro.Text)
            {
                case "Categoria":
                    //Define a localização dos controles
                    {
                        cbFiltro.Visible = true;
                        int x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + s;
                        cbFiltro.Location = new Point(x, cbTipoFiltro.Location.Y);
                        x = cbFiltro.Location.X + cbFiltro.Width + s;
                        btnFiltrar.Location = new Point(x, cbFiltro.Location.Y);
                    }
                    cbFiltro.DataSource = MetodosBd.GetCategorias();
                    cbFiltro.DisplayMember = "Categoria";
                    break;
                case "Status":
                    //Define a localização dos controles
                    {
                        cbFiltro.Visible = true;
                        int x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + s;
                        cbFiltro.Location = new Point(x, cbTipoFiltro.Location.Y);
                        x = cbFiltro.Location.X + cbFiltro.Width + s;
                        btnFiltrar.Location = new Point(x, cbFiltro.Location.Y);
                    }
                    cbFiltro.Items.AddRange(new string[] { "Ativo", "Inativo" });
                    break;
                case "Estoque":
                    //Define a localização dos controles
                    {
                        tbValFiltroIni.Visible = true;
                        tbValFiltroFin.Visible = true;
                        int x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + s;
                        tbValFiltroIni.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroIni.Text = "Qtd Inicial";
                        x = tbValFiltroIni.Location.X + tbValFiltroIni.Width + s;
                        tbValFiltroFin.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroFin.Text = "Qtd Final";
                        x = tbValFiltroFin.Location.X + tbValFiltroFin.Width + s;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }
                    break;

                case "Valor de Compra":
                    //Define a localização dos controles
                    {
                        tbValFiltroIni.Visible = true;
                        tbValFiltroFin.Visible = true;
                        int x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + s;
                        tbValFiltroIni.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroIni.Text = "Valor Inicial";
                        x = tbValFiltroIni.Location.X + tbValFiltroIni.Width + s;
                        tbValFiltroFin.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroFin.Text = "Valor Final";
                        x = tbValFiltroFin.Location.X + tbValFiltroFin.Width + s;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }
                    break;

                case "Valor de Venda":
                    //Define a localização dos controles
                    {
                        tbValFiltroIni.Visible = true;
                        tbValFiltroFin.Visible = true;
                        int x = cbTipoFiltro.Location.X + cbTipoFiltro.Width + s;
                        tbValFiltroIni.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroIni.Text = "Valor Inicial";
                        x = tbValFiltroIni.Location.X + tbValFiltroIni.Width + s;
                        tbValFiltroFin.Location = new Point(x, cbTipoFiltro.Location.Y);
                        tbValFiltroFin.Text = "Valor Final";
                        x = tbValFiltroFin.Location.X + tbValFiltroFin.Width + s;
                        btnFiltrar.Location = new Point(x, cbTipoFiltro.Location.Y);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AlterarBtnFiltro();
            
            switch (cbTipoFiltro.Text)
            {
                case "Categoria":
                    //Aplica o filtro no grid
                    AtualizaGrid(
                        ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                        .Where(x => x.Categoria == cbFiltro.Text)
                        .Select(x => x).ToList()
                        );
                    break;
                case "Status":
                    AtualizaGrid(
                        ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                        .Where(x => x.Estado ==
                        (cbFiltro.Text == "Ativo" ? true : false))
                        .Select(x => x).ToList()
                        );
                    break;
                case "Estoque":
                    if (tbValFiltroFin.Text == "" || tbValFiltroFin.Text == "Qtd Final")
                    {
                        AtualizaGrid(
                                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                    .Where(
                                        x => x.Estoque >= Convert.ToInt32(tbValFiltroIni.Text)
                                           )
                                    .Select(x => x).ToList()
                                    );
                    }
                    else
                    {
                        if (Convert.ToInt32(tbValFiltroFin.Text) < Convert.ToDouble(tbValFiltroIni.Text))
                        {
                            MessageBox.Show("O valor final deve ser maior que o inicial!");
                        }
                        else
                        {
                            AtualizaGrid(
                                                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                                    .Where(
                                                        x => x.Estoque >= Convert.ToInt32(tbValFiltroIni.Text) && x.Estoque <= Convert.ToInt32(tbValFiltroFin.Text)
                                                           )
                                                    .Select(x => x).ToList()
                                                    ); 
                        }
                    }
                    break;
                case "Valor de Compra":
                    if (tbValFiltroFin.Text == "" || tbValFiltroFin.Text == "Valor Final")
                    {
                        AtualizaGrid(
                                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                    .Where(
                                        x => x.ValorCompra >= Convert.ToDouble(tbValFiltroIni.Text.Replace("R$", ""))
                                           )
                                    .Select(x => x).ToList()
                                    );
                    }
                    else
                    {
                        if (Convert.ToDouble(tbValFiltroFin.Text.Replace("R$ ", "")) < Convert.ToDouble(tbValFiltroIni.Text.Replace("R$ ", "")))
                        {
                            MessageBox.Show("O valor final deve ser maior que o inicial!");
                        }
                        else
                        {
                            AtualizaGrid(
                                                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                                    .Where(
                                                        x => x.ValorCompra >= Convert.ToDouble(tbValFiltroIni.Text.Replace("R$", ""))
                                                        &&
                                                        x.ValorCompra <= Convert.ToDouble(tbValFiltroFin.Text.Replace("R$", ""))
                                                           )
                                                    .Select(x => x).ToList()
                                                    );  
                        }
                    }
                    break;
                case "Valor de Venda":
                    if (tbValFiltroFin.Text == "" || tbValFiltroFin.Text == "Valor Final")
                    {
                        AtualizaGrid(
                                    ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                    .Where(
                                        x => x.ValorVenda >= Convert.ToDouble(tbValFiltroIni.Text.Replace("R$", ""))
                                           )
                                    .Select(x => x).ToList()
                                    );
                    }
                    else
                    {

                        if (Convert.ToDouble(tbValFiltroFin.Text.Replace("R$ ", "")) < Convert.ToDouble(tbValFiltroIni.Text.Replace("R$ ", "")))
                        {
                            MessageBox.Show("O valor final deve ser maior que o inicial!");
                        }
                        else
                        {
                            AtualizaGrid
                                (
                                          ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                                          .Where(
                                           x => x.ValorVenda >= Convert.ToDouble(tbValFiltroIni.Text.Replace("R$", ""))
                                            &&
                                           x.ValorVenda <= Convert.ToDouble(tbValFiltroFin.Text.Replace("R$", ""))
                                                               )
                                           .Select(x => x).ToList()
                                );
                        }
                    }
                    break;

            }
        }



        private void tbValFiltroIni_Leave(object sender, EventArgs e)
        {

            if (cbTipoFiltro.Text == "Valor de Venda" || cbTipoFiltro.Text == "Valor de Compra")
            {
                try
                {
                    double valor = Convert.ToDouble(tbValFiltroIni.Text.Replace("R$ ", ""));
                    tbValFiltroIni.Text = valor.ToString("C2");
                }
                catch (Exception)
                {

                }
            }

        }

        private void tbValFiltroFin_Leave(object sender, EventArgs e)
        {
            if (cbTipoFiltro.Text == "Valor de Venda" || cbTipoFiltro.Text == "Valor de Compra")
            {
                try
                {
                    double valor = Convert.ToDouble(tbValFiltroFin.Text.Replace("R$ ", ""));
                    tbValFiltroFin.Text = valor.ToString("C2");
                }
                catch (Exception)
                {

                }
            }
        }

        private void tbValFiltroIni_Click(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbValFiltroIni.Text.Replace("R$", ""));
            }
            catch (Exception)
            {

                tbValFiltroIni.SelectAll();
            }
        }

        private void tbValFiltroFin_Click(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbValFiltroFin.Text.Replace("R$", ""));
            }
            catch (Exception)
            {

                tbValFiltroFin.SelectAll();
            }
        }

        private void btnVoltarPesq_Click(object sender, EventArgs e)
        {
            tbPesq.Clear();
            AtualizaGrid(ProdutosList);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbPesq.Text.Trim().All(char.IsDigit))
            {
                AtualizaGrid(
                        ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                        .Where(x => x.IdProduto == Convert.ToInt32(tbPesq.Text))
                        .Select(x => x).ToList()
                        );
            }
            else
            {
                AtualizaGrid(
                        ((List<VW_ProdutoGrid>)dgProdutos.DataSource)
                        .Where(x => x.Produto.ToUpper().Contains(tbPesq.Text.Trim().ToUpper()))
                        .Select(x => x).ToList()
                        );
            }
        }

        private void tbPesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnPesquisar_Click(sender, e);
            }
        }
    }
}
