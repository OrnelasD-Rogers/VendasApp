
namespace GUI
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbAddProduto = new System.Windows.Forms.GroupBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblProdAtivo = new System.Windows.Forms.Label();
            this.cbProdutoAtivo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.btnLimparProduto = new FontAwesome.Sharp.IconButton();
            this.btnAddNovoProd = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnNovoProduto = new FontAwesome.Sharp.IconButton();
            this.btnEditarProduto = new FontAwesome.Sharp.IconButton();
            this.btnExluirProduto = new FontAwesome.Sharp.IconButton();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.tbValFiltroIni = new System.Windows.Forms.TextBox();
            this.tbValFiltroFin = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.nudEstoqueMin = new System.Windows.Forms.NumericUpDown();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddProduto
            // 
            this.gbAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddProduto.BackColor = System.Drawing.Color.LightGray;
            this.gbAddProduto.Controls.Add(this.nudEstoqueMin);
            this.gbAddProduto.Controls.Add(this.label9);
            this.gbAddProduto.Controls.Add(this.cbModelo);
            this.gbAddProduto.Controls.Add(this.cbMarca);
            this.gbAddProduto.Controls.Add(this.cbTipo);
            this.gbAddProduto.Controls.Add(this.cbCategoria);
            this.gbAddProduto.Controls.Add(this.lblProdAtivo);
            this.gbAddProduto.Controls.Add(this.cbProdutoAtivo);
            this.gbAddProduto.Controls.Add(this.btnCancelar);
            this.gbAddProduto.Controls.Add(this.label10);
            this.gbAddProduto.Controls.Add(this.tbValorVenda);
            this.gbAddProduto.Controls.Add(this.btnLimparProduto);
            this.gbAddProduto.Controls.Add(this.btnAddNovoProd);
            this.gbAddProduto.Controls.Add(this.label7);
            this.gbAddProduto.Controls.Add(this.tbDescricao);
            this.gbAddProduto.Controls.Add(this.label6);
            this.gbAddProduto.Controls.Add(this.tbProduto);
            this.gbAddProduto.Controls.Add(this.label5);
            this.gbAddProduto.Controls.Add(this.label4);
            this.gbAddProduto.Controls.Add(this.label3);
            this.gbAddProduto.Controls.Add(this.label2);
            this.gbAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAddProduto.Location = new System.Drawing.Point(30, 438);
            this.gbAddProduto.Name = "gbAddProduto";
            this.gbAddProduto.Size = new System.Drawing.Size(969, 223);
            this.gbAddProduto.TabIndex = 22;
            this.gbAddProduto.TabStop = false;
            // 
            // cbModelo
            // 
            this.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelo.Location = new System.Drawing.Point(786, 58);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(162, 29);
            this.cbModelo.TabIndex = 31;
            // 
            // cbMarca
            // 
            this.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarca.Location = new System.Drawing.Point(595, 58);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(162, 29);
            this.cbMarca.TabIndex = 30;
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.Location = new System.Drawing.Point(402, 58);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(162, 29);
            this.cbTipo.TabIndex = 29;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.Location = new System.Drawing.Point(208, 58);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(162, 29);
            this.cbCategoria.TabIndex = 28;
            // 
            // lblProdAtivo
            // 
            this.lblProdAtivo.AutoSize = true;
            this.lblProdAtivo.Location = new System.Drawing.Point(398, 99);
            this.lblProdAtivo.Name = "lblProdAtivo";
            this.lblProdAtivo.Size = new System.Drawing.Size(113, 21);
            this.lblProdAtivo.TabIndex = 27;
            this.lblProdAtivo.Text = "Produto Ativo?";
            // 
            // cbProdutoAtivo
            // 
            this.cbProdutoAtivo.FormattingEnabled = true;
            this.cbProdutoAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbProdutoAtivo.Location = new System.Drawing.Point(402, 123);
            this.cbProdutoAtivo.Name = "cbProdutoAtivo";
            this.cbProdutoAtivo.Size = new System.Drawing.Size(162, 29);
            this.cbProdutoAtivo.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.Location = new System.Drawing.Point(937, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(32, 29);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Valor Venda (Unidade)";
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Location = new System.Drawing.Point(208, 123);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.Size = new System.Drawing.Size(162, 29);
            this.tbValorVenda.TabIndex = 23;
            this.tbValorVenda.Leave += new System.EventHandler(this.tbValorVenda_Leave);
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparProduto.FlatAppearance.BorderSize = 0;
            this.btnLimparProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparProduto.ForeColor = System.Drawing.Color.Black;
            this.btnLimparProduto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparProduto.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProduto.Location = new System.Drawing.Point(660, 143);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(141, 53);
            this.btnLimparProduto.TabIndex = 22;
            this.btnLimparProduto.Text = "Limpar Campos";
            this.btnLimparProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            this.btnLimparProduto.Click += new System.EventHandler(this.btnLimparProduto_Click);
            // 
            // btnAddNovoProd
            // 
            this.btnAddNovoProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNovoProd.FlatAppearance.BorderSize = 0;
            this.btnAddNovoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNovoProd.ForeColor = System.Drawing.Color.Black;
            this.btnAddNovoProd.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAddNovoProd.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNovoProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNovoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNovoProd.Location = new System.Drawing.Point(807, 143);
            this.btnAddNovoProd.Name = "btnAddNovoProd";
            this.btnAddNovoProd.Size = new System.Drawing.Size(141, 53);
            this.btnAddNovoProd.TabIndex = 21;
            this.btnAddNovoProd.Text = "Adicionar Produto";
            this.btnAddNovoProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNovoProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNovoProd.UseVisualStyleBackColor = true;
            this.btnAddNovoProd.Click += new System.EventHandler(this.btnAddNovoProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição do Produto";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(27, 123);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescricao.Size = new System.Drawing.Size(162, 91);
            this.tbDescricao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Produto";
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(27, 58);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(162, 29);
            this.tbProduto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Produto,
            this.Categoria,
            this.Tipo,
            this.Marca,
            this.Modelo,
            this.Descricao,
            this.ValorVenda,
            this.ValorCompra,
            this.Estoque,
            this.EstoqueMin,
            this.Estado});
            this.dgProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProdutos.Location = new System.Drawing.Point(30, 86);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(985, 284);
            this.dgProdutos.TabIndex = 23;
            this.dgProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProdutos_CellFormatting);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.Black;
            this.btnNovoProduto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNovoProduto.IconColor = System.Drawing.Color.Green;
            this.btnNovoProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovoProduto.IconSize = 35;
            this.btnNovoProduto.Location = new System.Drawing.Point(0, 0);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnNovoProduto.Size = new System.Drawing.Size(143, 56);
            this.btnNovoProduto.TabIndex = 26;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.FlatAppearance.BorderSize = 0;
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProduto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarProduto.IconColor = System.Drawing.Color.DimGray;
            this.btnEditarProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarProduto.IconSize = 35;
            this.btnEditarProduto.Location = new System.Drawing.Point(149, 0);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnEditarProduto.Size = new System.Drawing.Size(143, 56);
            this.btnEditarProduto.TabIndex = 27;
            this.btnEditarProduto.Text = "Editar Selecionado";
            this.btnEditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExluirProduto
            // 
            this.btnExluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluirProduto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluirProduto.ForeColor = System.Drawing.Color.Black;
            this.btnExluirProduto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExluirProduto.IconColor = System.Drawing.Color.DimGray;
            this.btnExluirProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExluirProduto.IconSize = 35;
            this.btnExluirProduto.Location = new System.Drawing.Point(298, 0);
            this.btnExluirProduto.Name = "btnExluirProduto";
            this.btnExluirProduto.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnExluirProduto.Size = new System.Drawing.Size(143, 56);
            this.btnExluirProduto.TabIndex = 28;
            this.btnExluirProduto.Text = "Excluir Selecionado";
            this.btnExluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExluirProduto.UseVisualStyleBackColor = true;
            this.btnExluirProduto.Click += new System.EventHandler(this.btnExluirProduto_Click);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.gbBotoes.Controls.Add(this.btnNovoProduto);
            this.gbBotoes.Controls.Add(this.btnExluirProduto);
            this.gbBotoes.Controls.Add(this.btnEditarProduto);
            this.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBotoes.Location = new System.Drawing.Point(30, 376);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(445, 61);
            this.gbBotoes.TabIndex = 29;
            this.gbBotoes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pesquisar Produto :";
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(176, 51);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(745, 29);
            this.tbPesq.TabIndex = 30;
            this.tbPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesq_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.SlateGray;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 35;
            this.btnPesquisar.Location = new System.Drawing.Point(927, 50);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltarPesq
            // 
            this.btnVoltarPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarPesq.FlatAppearance.BorderSize = 0;
            this.btnVoltarPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarPesq.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPesq.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarPesq.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnVoltarPesq.IconColor = System.Drawing.Color.IndianRed;
            this.btnVoltarPesq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoltarPesq.IconSize = 40;
            this.btnVoltarPesq.Location = new System.Drawing.Point(974, 50);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 33;
            this.btnVoltarPesq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarPesq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarPesq.UseVisualStyleBackColor = true;
            this.btnVoltarPesq.Click += new System.EventHandler(this.btnVoltarPesq_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltrar.IconColor = System.Drawing.Color.SlateGray;
            this.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltrar.IconSize = 35;
            this.btnFiltrar.Location = new System.Drawing.Point(325, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnFiltrar.Size = new System.Drawing.Size(41, 29);
            this.btnFiltrar.TabIndex = 34;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Categoria",
            "Status",
            "Estoque",
            "Valor de Compra",
            "Valor de Venda"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(176, 12);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(143, 29);
            this.cbTipoFiltro.TabIndex = 35;
            this.cbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbTipoFiltro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Filtrar Produtos :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Categoria",
            "Status",
            "Estoque",
            "Valor de Compra",
            "Valor de Venda"});
            this.cbFiltro.Location = new System.Drawing.Point(325, 12);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(143, 29);
            this.cbFiltro.TabIndex = 37;
            this.cbFiltro.Visible = false;
            // 
            // tbValFiltroIni
            // 
            this.tbValFiltroIni.Location = new System.Drawing.Point(494, 13);
            this.tbValFiltroIni.Name = "tbValFiltroIni";
            this.tbValFiltroIni.Size = new System.Drawing.Size(100, 29);
            this.tbValFiltroIni.TabIndex = 38;
            this.tbValFiltroIni.Visible = false;
            this.tbValFiltroIni.Click += new System.EventHandler(this.tbValFiltroIni_Click);
            this.tbValFiltroIni.Leave += new System.EventHandler(this.tbValFiltroIni_Leave);
            // 
            // tbValFiltroFin
            // 
            this.tbValFiltroFin.Location = new System.Drawing.Point(609, 13);
            this.tbValFiltroFin.Name = "tbValFiltroFin";
            this.tbValFiltroFin.Size = new System.Drawing.Size(100, 29);
            this.tbValFiltroFin.TabIndex = 39;
            this.tbValFiltroFin.Visible = false;
            this.tbValFiltroFin.Click += new System.EventHandler(this.tbValFiltroFin_Click);
            this.tbValFiltroFin.Leave += new System.EventHandler(this.tbValFiltroFin_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Estoque Minimo";
            // 
            // nudEstoqueMin
            // 
            this.nudEstoqueMin.Location = new System.Drawing.Point(207, 185);
            this.nudEstoqueMin.Name = "nudEstoqueMin";
            this.nudEstoqueMin.Size = new System.Drawing.Size(163, 29);
            this.nudEstoqueMin.TabIndex = 34;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.HeaderText = "Id Produto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 70;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 180;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "ValorVenda";
            this.ValorVenda.HeaderText = "Valor Venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            this.ValorVenda.Width = 85;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "Valor Compra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            this.ValorCompra.Width = 85;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "Estoque";
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 80;
            // 
            // EstoqueMin
            // 
            this.EstoqueMin.DataPropertyName = "EstoqueMin";
            this.EstoqueMin.HeaderText = "Estoque Min";
            this.EstoqueMin.Name = "EstoqueMin";
            this.EstoqueMin.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Status";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.tbValFiltroFin);
            this.Controls.Add(this.tbValFiltroIni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesq);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.gbAddProduto);
            this.Controls.Add(this.cbFiltro);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.gbAddProduto.ResumeLayout(false);
            this.gbAddProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbValorVenda;
        private FontAwesome.Sharp.IconButton btnLimparProduto;
        private FontAwesome.Sharp.IconButton btnAddNovoProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProdutos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnNovoProduto;
        private FontAwesome.Sharp.IconButton btnEditarProduto;
        private FontAwesome.Sharp.IconButton btnExluirProduto;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.Label lblProdAtivo;
        private System.Windows.Forms.ComboBox cbProdutoAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.TextBox tbValFiltroIni;
        private System.Windows.Forms.TextBox tbValFiltroFin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nudEstoqueMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}