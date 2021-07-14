
namespace GUI
{
    partial class FormNovaVenda
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
            this.gbAddCompra = new System.Windows.Forms.GroupBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnContador = new FontAwesome.Sharp.IconButton();
            this.btnCarrinho = new FontAwesome.Sharp.IconButton();
            this.btnAdicionarVenda = new FontAwesome.Sharp.IconButton();
            this.btnAddItem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
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
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddCompra
            // 
            this.gbAddCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAddCompra.Controls.Add(this.tbQuantidade);
            this.gbAddCompra.Controls.Add(this.label9);
            this.gbAddCompra.Controls.Add(this.tbModelo);
            this.gbAddCompra.Controls.Add(this.tbMarca);
            this.gbAddCompra.Controls.Add(this.tbTipo);
            this.gbAddCompra.Controls.Add(this.tbCategoria);
            this.gbAddCompra.Controls.Add(this.label10);
            this.gbAddCompra.Controls.Add(this.tbValorVenda);
            this.gbAddCompra.Controls.Add(this.label7);
            this.gbAddCompra.Controls.Add(this.tbDescricao);
            this.gbAddCompra.Controls.Add(this.label6);
            this.gbAddCompra.Controls.Add(this.tbProduto);
            this.gbAddCompra.Controls.Add(this.label5);
            this.gbAddCompra.Controls.Add(this.label4);
            this.gbAddCompra.Controls.Add(this.label3);
            this.gbAddCompra.Controls.Add(this.label8);
            this.gbAddCompra.Controls.Add(this.btnContador);
            this.gbAddCompra.Controls.Add(this.btnCarrinho);
            this.gbAddCompra.Controls.Add(this.btnAdicionarVenda);
            this.gbAddCompra.Controls.Add(this.btnAddItem);
            this.gbAddCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAddCompra.Location = new System.Drawing.Point(16, 397);
            this.gbAddCompra.Name = "gbAddCompra";
            this.gbAddCompra.Size = new System.Drawing.Size(982, 236);
            this.gbAddCompra.TabIndex = 52;
            this.gbAddCompra.TabStop = false;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuantidade.Location = new System.Drawing.Point(587, 94);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(162, 29);
            this.tbQuantidade.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 49;
            this.label9.Text = "Quantidade";
            // 
            // tbModelo
            // 
            this.tbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModelo.Location = new System.Drawing.Point(776, 28);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.ReadOnly = true;
            this.tbModelo.Size = new System.Drawing.Size(162, 29);
            this.tbModelo.TabIndex = 48;
            // 
            // tbMarca
            // 
            this.tbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarca.Location = new System.Drawing.Point(586, 28);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(162, 29);
            this.tbMarca.TabIndex = 47;
            // 
            // tbTipo
            // 
            this.tbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTipo.Location = new System.Drawing.Point(393, 28);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.ReadOnly = true;
            this.tbTipo.Size = new System.Drawing.Size(162, 29);
            this.tbTipo.TabIndex = 46;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategoria.Location = new System.Drawing.Point(199, 28);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.ReadOnly = true;
            this.tbCategoria.Size = new System.Drawing.Size(162, 29);
            this.tbCategoria.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Valor Venda (Unidade)";
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorVenda.Location = new System.Drawing.Point(393, 94);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.ReadOnly = true;
            this.tbValorVenda.Size = new System.Drawing.Size(162, 29);
            this.tbValorVenda.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Descrição do Produto";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.Location = new System.Drawing.Point(18, 94);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescricao.Size = new System.Drawing.Size(343, 83);
            this.tbDescricao.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Produto";
            // 
            // tbProduto
            // 
            this.tbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProduto.Location = new System.Drawing.Point(18, 28);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.ReadOnly = true;
            this.tbProduto.Size = new System.Drawing.Size(162, 29);
            this.tbProduto.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Marca";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tipo";
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
            this.btnContador.Location = new System.Drawing.Point(752, 171);
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
            this.btnCarrinho.Location = new System.Drawing.Point(677, 171);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(137, 53);
            this.btnCarrinho.TabIndex = 33;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarrinho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarVenda.FlatAppearance.BorderSize = 0;
            this.btnAdicionarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarVenda.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarVenda.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAdicionarVenda.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarVenda.Location = new System.Drawing.Point(831, 171);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(141, 53);
            this.btnAdicionarVenda.TabIndex = 21;
            this.btnAdicionarVenda.Text = "Finalizar Venda";
            this.btnAdicionarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click);
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
            this.btnAddItem.Location = new System.Drawing.Point(519, 171);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(152, 53);
            this.btnAddItem.TabIndex = 33;
            this.btnAddItem.Text = "Adicionar Ao Carrinho";
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Pesquisar Produto :";
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(162, 15);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(769, 29);
            this.tbPesq.TabIndex = 54;
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToResizeColumns = false;
            this.dgProdutos.AllowUserToResizeRows = false;
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
            this.Estado});
            this.dgProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProdutos.Location = new System.Drawing.Point(16, 50);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(1009, 341);
            this.dgProdutos.TabIndex = 53;
            this.dgProdutos.TabStop = false;
            this.dgProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProdutos_CellFormatting);
            this.dgProdutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProdutos_CellMouseClick);
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
            this.Produto.Width = 250;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 180;
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
            this.Descricao.Width = 300;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "ValorVenda";
            this.ValorVenda.HeaderText = "Valor Venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            this.ValorVenda.Width = 90;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "Valor Compra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            this.ValorCompra.Visible = false;
            this.ValorCompra.Width = 90;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "Estoque";
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Status";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 65;
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(984, 14);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 57;
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
            this.btnPesquisar.Location = new System.Drawing.Point(937, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 56;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPesq);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.gbAddCompra);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNovaVenda";
            this.Text = "FormNovaVenda";
            this.gbAddCompra.ResumeLayout(false);
            this.gbAddCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddCompra;
        private FontAwesome.Sharp.IconButton btnContador;
        private FontAwesome.Sharp.IconButton btnCarrinho;
        private FontAwesome.Sharp.IconButton btnAdicionarVenda;
        private FontAwesome.Sharp.IconButton btnAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPesq;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbValorVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
    }
}