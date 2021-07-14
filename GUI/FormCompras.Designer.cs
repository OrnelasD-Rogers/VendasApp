
namespace GUI
{
    partial class FormCompras
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
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.gbAddCompra = new System.Windows.Forms.GroupBox();
            this.btnContador = new FontAwesome.Sharp.IconButton();
            this.btnCarrinho = new FontAwesome.Sharp.IconButton();
            this.gbAddProd = new System.Windows.Forms.GroupBox();
            this.btnFechaItem = new FontAwesome.Sharp.IconButton();
            this.btnAddProdLista = new FontAwesome.Sharp.IconButton();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValorUn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNotaFiscal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionarCompra = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbValorFrete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new FontAwesome.Sharp.IconButton();
            this.btnNovaCompra = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDataIni = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epProduto = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnItensCompra = new FontAwesome.Sharp.IconButton();
            this.gbAddCompra.SuspendLayout();
            this.gbAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 35;
            this.btnCancelar.Location = new System.Drawing.Point(950, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(32, 29);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbAddCompra
            // 
            this.gbAddCompra.Controls.Add(this.btnContador);
            this.gbAddCompra.Controls.Add(this.btnCarrinho);
            this.gbAddCompra.Controls.Add(this.gbAddProd);
            this.gbAddCompra.Controls.Add(this.btnCancelar);
            this.gbAddCompra.Controls.Add(this.tbNotaFiscal);
            this.gbAddCompra.Controls.Add(this.label16);
            this.gbAddCompra.Controls.Add(this.cbFornecedor);
            this.gbAddCompra.Controls.Add(this.label14);
            this.gbAddCompra.Controls.Add(this.dtpDataCompra);
            this.gbAddCompra.Controls.Add(this.btnAdicionarCompra);
            this.gbAddCompra.Controls.Add(this.label8);
            this.gbAddCompra.Controls.Add(this.tbDescCompra);
            this.gbAddCompra.Controls.Add(this.label9);
            this.gbAddCompra.Controls.Add(this.label11);
            this.gbAddCompra.Controls.Add(this.tbValorFrete);
            this.gbAddCompra.Controls.Add(this.label12);
            this.gbAddCompra.Controls.Add(this.tbValorTotal);
            this.gbAddCompra.Controls.Add(this.btnAddItem);
            this.gbAddCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAddCompra.Location = new System.Drawing.Point(23, 407);
            this.gbAddCompra.Name = "gbAddCompra";
            this.gbAddCompra.Size = new System.Drawing.Size(982, 320);
            this.gbAddCompra.TabIndex = 23;
            this.gbAddCompra.TabStop = false;
            // 
            // btnContador
            // 
            this.btnContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContador.FlatAppearance.BorderSize = 0;
            this.btnContador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContador.ForeColor = System.Drawing.Color.Black;
            this.btnContador.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btnContador.IconColor = System.Drawing.Color.OrangeRed;
            this.btnContador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContador.IconSize = 30;
            this.btnContador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContador.Location = new System.Drawing.Point(752, 255);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(25, 28);
            this.btnContador.TabIndex = 34;
            this.btnContador.Text = "0";
            this.btnContador.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnContador.UseVisualStyleBackColor = true;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarrinho.FlatAppearance.BorderSize = 0;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.ForeColor = System.Drawing.Color.Black;
            this.btnCarrinho.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCarrinho.IconColor = System.Drawing.Color.SlateGray;
            this.btnCarrinho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrinho.Location = new System.Drawing.Point(677, 255);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(137, 53);
            this.btnCarrinho.TabIndex = 33;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarrinho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // gbAddProd
            // 
            this.gbAddProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbAddProd.Controls.Add(this.btnFechaItem);
            this.gbAddProd.Controls.Add(this.btnAddProdLista);
            this.gbAddProd.Controls.Add(this.chbEstado);
            this.gbAddProd.Controls.Add(this.tbSubTotal);
            this.gbAddProd.Controls.Add(this.label2);
            this.gbAddProd.Controls.Add(this.cbProdutos);
            this.gbAddProd.Controls.Add(this.label1);
            this.gbAddProd.Controls.Add(this.tbValorUn);
            this.gbAddProd.Controls.Add(this.label13);
            this.gbAddProd.Controls.Add(this.tbQuantidade);
            this.gbAddProd.Controls.Add(this.label15);
            this.gbAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAddProd.Location = new System.Drawing.Point(18, 206);
            this.gbAddProd.Name = "gbAddProd";
            this.gbAddProd.Size = new System.Drawing.Size(614, 147);
            this.gbAddProd.TabIndex = 31;
            this.gbAddProd.TabStop = false;
            this.gbAddProd.Visible = false;
            // 
            // btnFechaItem
            // 
            this.btnFechaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechaItem.FlatAppearance.BorderSize = 0;
            this.btnFechaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFechaItem.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnFechaItem.IconColor = System.Drawing.Color.OrangeRed;
            this.btnFechaItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechaItem.IconSize = 30;
            this.btnFechaItem.Location = new System.Drawing.Point(586, 5);
            this.btnFechaItem.Name = "btnFechaItem";
            this.btnFechaItem.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.btnFechaItem.Size = new System.Drawing.Size(22, 21);
            this.btnFechaItem.TabIndex = 35;
            this.btnFechaItem.UseVisualStyleBackColor = true;
            this.btnFechaItem.Click += new System.EventHandler(this.btnFechaItem_Click);
            // 
            // btnAddProdLista
            // 
            this.btnAddProdLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProdLista.FlatAppearance.BorderSize = 0;
            this.btnAddProdLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdLista.ForeColor = System.Drawing.Color.Black;
            this.btnAddProdLista.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnAddProdLista.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAddProdLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProdLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProdLista.Location = new System.Drawing.Point(450, 88);
            this.btnAddProdLista.Name = "btnAddProdLista";
            this.btnAddProdLista.Size = new System.Drawing.Size(158, 53);
            this.btnAddProdLista.TabIndex = 32;
            this.btnAddProdLista.Text = "Adicionar ao Carrinho";
            this.btnAddProdLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProdLista.UseVisualStyleBackColor = true;
            this.btnAddProdLista.Click += new System.EventHandler(this.btnAddProdLista_Click);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.ForeColor = System.Drawing.Color.Red;
            this.chbEstado.Location = new System.Drawing.Point(496, 32);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(112, 25);
            this.chbEstado.TabIndex = 36;
            this.chbEstado.Text = "Oferta Ativa";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(310, 107);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(119, 29);
            this.tbSubTotal.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "SubTotal";
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(6, 28);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(461, 29);
            this.cbProdutos.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Produto";
            // 
            // tbValorUn
            // 
            this.tbValorUn.Location = new System.Drawing.Point(149, 107);
            this.tbValorUn.Name = "tbValorUn";
            this.tbValorUn.Size = new System.Drawing.Size(133, 29);
            this.tbValorUn.TabIndex = 3;
            this.tbValorUn.Text = "R$ ";
            this.tbValorUn.TextChanged += new System.EventHandler(this.tbValorUn_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Custo por Unidade";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(6, 107);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(116, 29);
            this.tbQuantidade.TabIndex = 28;
            this.tbQuantidade.TextChanged += new System.EventHandler(this.tbQuantidade_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 27;
            this.label15.Text = "Quantidade";
            // 
            // tbNotaFiscal
            // 
            this.tbNotaFiscal.Location = new System.Drawing.Point(628, 41);
            this.tbNotaFiscal.Name = "tbNotaFiscal";
            this.tbNotaFiscal.Size = new System.Drawing.Size(173, 29);
            this.tbNotaFiscal.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(624, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.TabIndex = 29;
            this.label16.Text = "Nota Fiscal";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(425, 41);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(173, 29);
            this.cbFornecedor.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Fornecedor";
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(222, 41);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(173, 29);
            this.dtpDataCompra.TabIndex = 23;
            // 
            // btnAdicionarCompra
            // 
            this.btnAdicionarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarCompra.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarCompra.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAdicionarCompra.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarCompra.Location = new System.Drawing.Point(831, 255);
            this.btnAdicionarCompra.Name = "btnAdicionarCompra";
            this.btnAdicionarCompra.Size = new System.Drawing.Size(141, 53);
            this.btnAdicionarCompra.TabIndex = 21;
            this.btnAdicionarCompra.Text = "Adicionar Compra";
            this.btnAdicionarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarCompra.UseVisualStyleBackColor = true;
            this.btnAdicionarCompra.Click += new System.EventHandler(this.btnAdicionarCompra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descrição da Compra";
            // 
            // tbDescCompra
            // 
            this.tbDescCompra.Location = new System.Drawing.Point(19, 41);
            this.tbDescCompra.MaxLength = 99;
            this.tbDescCompra.Multiline = true;
            this.tbDescCompra.Name = "tbDescCompra";
            this.tbDescCompra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescCompra.Size = new System.Drawing.Size(173, 95);
            this.tbDescCompra.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data da Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Valor Frete";
            // 
            // tbValorFrete
            // 
            this.tbValorFrete.Location = new System.Drawing.Point(222, 107);
            this.tbValorFrete.Name = "tbValorFrete";
            this.tbValorFrete.Size = new System.Drawing.Size(173, 29);
            this.tbValorFrete.TabIndex = 7;
            this.tbValorFrete.Leave += new System.EventHandler(this.tbValorFrete_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Valor Total (Sem frete)";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(425, 107);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(173, 29);
            this.tbValorTotal.TabIndex = 5;
            this.tbValorTotal.Leave += new System.EventHandler(this.tbValorTotal_Leave);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddItem.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(19, 157);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(125, 53);
            this.btnAddItem.TabIndex = 33;
            this.btnAddItem.Text = "Inserir Produto";
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNovaCompra.FlatAppearance.BorderSize = 0;
            this.btnNovaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCompra.ForeColor = System.Drawing.Color.Black;
            this.btnNovaCompra.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNovaCompra.IconColor = System.Drawing.Color.ForestGreen;
            this.btnNovaCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaCompra.Location = new System.Drawing.Point(901, 331);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(125, 53);
            this.btnNovaCompra.TabIndex = 37;
            this.btnNovaCompra.Text = "Nova Compra";
            this.btnNovaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Filtrar Compras por Data :";
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
            this.btnFiltrar.Location = new System.Drawing.Point(531, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnFiltrar.Size = new System.Drawing.Size(36, 29);
            this.btnFiltrar.TabIndex = 38;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(254, 12);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(110, 29);
            this.dtpInicial.TabIndex = 42;
            // 
            // lblDataIni
            // 
            this.lblDataIni.AutoSize = true;
            this.lblDataIni.Location = new System.Drawing.Point(219, 16);
            this.lblDataIni.Name = "lblDataIni";
            this.lblDataIni.Size = new System.Drawing.Size(29, 21);
            this.lblDataIni.TabIndex = 43;
            this.lblDataIni.Text = "De";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(370, 16);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(33, 21);
            this.lblDataFinal.TabIndex = 44;
            this.lblDataFinal.Text = "Até";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(409, 12);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(110, 29);
            this.dtpFinal.TabIndex = 45;
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(995, 62);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 49;
            this.btnVoltarPesq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarPesq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarPesq.UseVisualStyleBackColor = true;
            this.btnVoltarPesq.Click += new System.EventHandler(this.btnVoltarPesq_Click);
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
            this.btnPesquisar.Location = new System.Drawing.Point(954, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Pesquisar Compra Por :";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesquisa.Location = new System.Drawing.Point(427, 63);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(511, 29);
            this.tbPesquisa.TabIndex = 46;
            this.tbPesquisa.Enter += new System.EventHandler(this.tbPesquisa_Enter);
            // 
            // cbTipoPesquisa
            // 
            this.cbTipoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPesquisa.FormattingEnabled = true;
            this.cbTipoPesquisa.Items.AddRange(new object[] {
            "Id Compra",
            "Nota Fiscal",
            "Fornecedor",
            "Valor Total",
            "Valor Frete"});
            this.cbTipoPesquisa.Location = new System.Drawing.Point(200, 63);
            this.cbTipoPesquisa.Name = "cbTipoPesquisa";
            this.cbTipoPesquisa.Size = new System.Drawing.Size(205, 29);
            this.cbTipoPesquisa.TabIndex = 50;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.AllowUserToDeleteRows = false;
            this.dgCompras.AllowUserToResizeRows = false;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCompra,
            this.DataCompra,
            this.Compra,
            this.NotaFiscal,
            this.ValorFrete,
            this.ValorTotal,
            this.Fornecedor});
            this.dgCompras.Location = new System.Drawing.Point(23, 97);
            this.dgCompras.MultiSelect = false;
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            this.dgCompras.RowHeadersVisible = false;
            this.dgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCompras.ShowCellToolTips = false;
            this.dgCompras.Size = new System.Drawing.Size(1003, 227);
            this.dgCompras.TabIndex = 51;
            this.dgCompras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCompras_CellFormatting);
            // 
            // IdCompra
            // 
            this.IdCompra.DataPropertyName = "IdCompra";
            this.IdCompra.HeaderText = "Id Compra";
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            this.IdCompra.Width = 70;
            // 
            // DataCompra
            // 
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.HeaderText = "Data Compra";
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.ReadOnly = true;
            // 
            // Compra
            // 
            this.Compra.DataPropertyName = "Compra";
            this.Compra.HeaderText = "Compra";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            this.Compra.Width = 300;
            // 
            // NotaFiscal
            // 
            this.NotaFiscal.DataPropertyName = "NotaFiscal";
            this.NotaFiscal.HeaderText = "Nota Fiscal";
            this.NotaFiscal.Name = "NotaFiscal";
            this.NotaFiscal.ReadOnly = true;
            this.NotaFiscal.Width = 130;
            // 
            // ValorFrete
            // 
            this.ValorFrete.DataPropertyName = "ValorFrete";
            this.ValorFrete.HeaderText = "ValorFrete";
            this.ValorFrete.Name = "ValorFrete";
            this.ValorFrete.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 160;
            // 
            // epProduto
            // 
            this.epProduto.ContainerControl = this;
            // 
            // epCompra
            // 
            this.epCompra.ContainerControl = this;
            // 
            // btnItensCompra
            // 
            this.btnItensCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItensCompra.FlatAppearance.BorderSize = 0;
            this.btnItensCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensCompra.ForeColor = System.Drawing.Color.Black;
            this.btnItensCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnItensCompra.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnItensCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItensCompra.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnItensCompra.Location = new System.Drawing.Point(754, 331);
            this.btnItensCompra.Name = "btnItensCompra";
            this.btnItensCompra.Size = new System.Drawing.Size(141, 53);
            this.btnItensCompra.TabIndex = 52;
            this.btnItensCompra.Text = "Itens da Compra";
            this.btnItensCompra.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnItensCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItensCompra.UseVisualStyleBackColor = true;
            this.btnItensCompra.Click += new System.EventHandler(this.btnItensCompra_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.cbTipoPesquisa);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataIni);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.gbAddCompra);
            this.Controls.Add(this.btnItensCompra);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.gbAddCompra.ResumeLayout(false);
            this.gbAddCompra.PerformLayout();
            this.gbAddProd.ResumeLayout(false);
            this.gbAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.GroupBox gbAddCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private FontAwesome.Sharp.IconButton btnAdicionarCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDescCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbValorFrete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbValorUn;
        private System.Windows.Forms.TextBox tbNotaFiscal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.GroupBox gbAddProd;
        private FontAwesome.Sharp.IconButton btnAddProdLista;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAddItem;
        private FontAwesome.Sharp.IconButton btnCarrinho;
        private FontAwesome.Sharp.IconButton btnContador;
        private FontAwesome.Sharp.IconButton btnNovaCompra;
        private FontAwesome.Sharp.IconButton btnFechaItem;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lblDataIni;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ComboBox cbTipoPesquisa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.ErrorProvider epProduto;
        private System.Windows.Forms.ErrorProvider epCompra;
        private FontAwesome.Sharp.IconButton btnItensCompra;
    }
}