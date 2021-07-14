
namespace GUI
{
    partial class FormPagamento
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
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoPag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalAPagar = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.IdProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelPagamento = new System.Windows.Forms.Panel();
            this.btnFinalizarPag = new FontAwesome.Sharp.IconButton();
            this.pnParcelas = new System.Windows.Forms.Panel();
            this.nudNumParc = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.tbNumComp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoVenda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoComp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVendedores = new System.Windows.Forms.ComboBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhatsApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelPagamento.SuspendLayout();
            this.pnParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumParc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(984, 66);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 61;
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
            this.btnPesquisar.Location = new System.Drawing.Point(937, 66);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 60;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(136, 21);
            this.lblCliente.TabIndex = 59;
            this.lblCliente.Text = "Pesquisar Cliente :";
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(154, 66);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(777, 29);
            this.tbPesq.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Forma de Pagamento";
            // 
            // cbTipoPag
            // 
            this.cbTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPag.FormattingEnabled = true;
            this.cbTipoPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Credito",
            "Debito"});
            this.cbTipoPag.Location = new System.Drawing.Point(644, 100);
            this.cbTipoPag.Name = "cbTipoPag";
            this.cbTipoPag.Size = new System.Drawing.Size(137, 29);
            this.cbTipoPag.TabIndex = 64;
            this.cbTipoPag.SelectedIndexChanged += new System.EventHandler(this.cbTipoPag_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "Valor a Pagar";
            // 
            // tbTotalAPagar
            // 
            this.tbTotalAPagar.Enabled = false;
            this.tbTotalAPagar.Location = new System.Drawing.Point(644, 36);
            this.tbTotalAPagar.Name = "tbTotalAPagar";
            this.tbTotalAPagar.Size = new System.Drawing.Size(137, 29);
            this.tbTotalAPagar.TabIndex = 66;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(828, 36);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(137, 29);
            this.tbDesconto.TabIndex = 72;
            this.tbDesconto.Text = " %";
            this.tbDesconto.Click += new System.EventHandler(this.tbDesconto_Click);
            this.tbDesconto.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "Desconto (%)";
            // 
            // lvProdutos
            // 
            this.lvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProduto,
            this.Produto,
            this.Valor,
            this.Quantidade,
            this.Subtotal});
            this.lvProdutos.GridLines = true;
            this.lvProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProdutos.HideSelection = false;
            this.lvProdutos.Location = new System.Drawing.Point(0, 12);
            this.lvProdutos.MultiSelect = false;
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(619, 311);
            this.lvProdutos.TabIndex = 73;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            this.lvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // IdProduto
            // 
            this.IdProduto.Text = "IdProd.";
            this.IdProduto.Width = 82;
            // 
            // Produto
            // 
            this.Produto.Text = "Prod.";
            this.Produto.Width = 266;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 107;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quant.";
            this.Quantidade.Width = 66;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "SubTot.";
            this.Subtotal.Width = 91;
            // 
            // panelPagamento
            // 
            this.panelPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPagamento.Controls.Add(this.btnFinalizarPag);
            this.panelPagamento.Controls.Add(this.pnParcelas);
            this.panelPagamento.Controls.Add(this.label9);
            this.panelPagamento.Controls.Add(this.dtpDataVenda);
            this.panelPagamento.Controls.Add(this.tbNumComp);
            this.panelPagamento.Controls.Add(this.label7);
            this.panelPagamento.Controls.Add(this.cbTipoVenda);
            this.panelPagamento.Controls.Add(this.label6);
            this.panelPagamento.Controls.Add(this.cbTipoComp);
            this.panelPagamento.Controls.Add(this.label2);
            this.panelPagamento.Controls.Add(this.tbDesconto);
            this.panelPagamento.Controls.Add(this.lvProdutos);
            this.panelPagamento.Controls.Add(this.label4);
            this.panelPagamento.Controls.Add(this.tbTotalAPagar);
            this.panelPagamento.Controls.Add(this.label3);
            this.panelPagamento.Controls.Add(this.cbTipoPag);
            this.panelPagamento.Controls.Add(this.label1);
            this.panelPagamento.Location = new System.Drawing.Point(16, 326);
            this.panelPagamento.Name = "panelPagamento";
            this.panelPagamento.Size = new System.Drawing.Size(1010, 326);
            this.panelPagamento.TabIndex = 74;
            // 
            // btnFinalizarPag
            // 
            this.btnFinalizarPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarPag.Enabled = false;
            this.btnFinalizarPag.FlatAppearance.BorderSize = 0;
            this.btnFinalizarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPag.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarPag.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnFinalizarPag.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizarPag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizarPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarPag.Location = new System.Drawing.Point(753, 263);
            this.btnFinalizarPag.Name = "btnFinalizarPag";
            this.btnFinalizarPag.Size = new System.Drawing.Size(141, 53);
            this.btnFinalizarPag.TabIndex = 85;
            this.btnFinalizarPag.Text = "Finalizar Venda";
            this.btnFinalizarPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizarPag.UseVisualStyleBackColor = true;
            this.btnFinalizarPag.Click += new System.EventHandler(this.btnFinalizarPag_Click);
            // 
            // pnParcelas
            // 
            this.pnParcelas.Controls.Add(this.nudNumParc);
            this.pnParcelas.Controls.Add(this.label8);
            this.pnParcelas.Location = new System.Drawing.Point(818, 72);
            this.pnParcelas.Name = "pnParcelas";
            this.pnParcelas.Size = new System.Drawing.Size(89, 57);
            this.pnParcelas.TabIndex = 84;
            this.pnParcelas.Visible = false;
            // 
            // nudNumParc
            // 
            this.nudNumParc.Location = new System.Drawing.Point(10, 27);
            this.nudNumParc.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNumParc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumParc.Name = "nudNumParc";
            this.nudNumParc.Size = new System.Drawing.Size(73, 29);
            this.nudNumParc.TabIndex = 83;
            this.nudNumParc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 80;
            this.label8.Text = "Parcelas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(814, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 82;
            this.label9.Text = "Data da Venda";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(828, 228);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(137, 29);
            this.dtpDataVenda.TabIndex = 81;
            // 
            // tbNumComp
            // 
            this.tbNumComp.Location = new System.Drawing.Point(828, 164);
            this.tbNumComp.Name = "tbNumComp";
            this.tbNumComp.Size = new System.Drawing.Size(137, 29);
            this.tbNumComp.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(814, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 21);
            this.label7.TabIndex = 78;
            this.label7.Text = "Comprovante (Numero)";
            // 
            // cbTipoVenda
            // 
            this.cbTipoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVenda.FormattingEnabled = true;
            this.cbTipoVenda.Items.AddRange(new object[] {
            "Balcao",
            "Internet"});
            this.cbTipoVenda.Location = new System.Drawing.Point(644, 228);
            this.cbTipoVenda.Name = "cbTipoVenda";
            this.cbTipoVenda.Size = new System.Drawing.Size(144, 29);
            this.cbTipoVenda.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tipo de Venda";
            // 
            // cbTipoComp
            // 
            this.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComp.FormattingEnabled = true;
            this.cbTipoComp.Items.AddRange(new object[] {
            "NF-e",
            "NFC-e",
            "N/A"});
            this.cbTipoComp.Location = new System.Drawing.Point(644, 164);
            this.cbTipoComp.Name = "cbTipoComp";
            this.cbTipoComp.Size = new System.Drawing.Size(144, 29);
            this.cbTipoComp.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tipo de Comprovante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 75;
            this.label5.Text = "Vendedor :";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVendedores.FormattingEnabled = true;
            this.cbVendedores.Location = new System.Drawing.Point(103, 19);
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Size = new System.Drawing.Size(828, 29);
            this.cbVendedores.TabIndex = 76;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nome,
            this.Sexo,
            this.CPF,
            this.Email,
            this.Telefone,
            this.WhatsApp});
            this.dgClientes.Location = new System.Drawing.Point(16, 101);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.RowTemplate.Height = 28;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(1009, 219);
            this.dgClientes.TabIndex = 77;
            this.dgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellDoubleClick);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Id Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 65;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 230;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 85;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "Cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 135;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 230;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 130;
            // 
            // WhatsApp
            // 
            this.WhatsApp.DataPropertyName = "WhatsApp";
            this.WhatsApp.HeaderText = "WhatsApp";
            this.WhatsApp.Name = "WhatsApp";
            this.WhatsApp.ReadOnly = true;
            this.WhatsApp.Width = 130;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.cbVendedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelPagamento);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.tbPesq);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPagamento";
            this.Text = "FormPagamento";
            this.panelPagamento.ResumeLayout(false);
            this.panelPagamento.PerformLayout();
            this.pnParcelas.ResumeLayout(false);
            this.pnParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumParc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalAPagar;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.Panel panelPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVendedores;
        private System.Windows.Forms.ColumnHeader IdProduto;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumComp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhatsApp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nudNumParc;
        private System.Windows.Forms.Panel pnParcelas;
        private FontAwesome.Sharp.IconButton btnFinalizarPag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}