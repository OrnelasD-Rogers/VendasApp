
namespace GUI
{
    partial class FormVendas
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
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.tbValFiltroIni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbValFiltroFin = new System.Windows.Forms.TextBox();
            this.dtpDataIni = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFin = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.cbTipoVenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDataVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.btnItensVenda = new FontAwesome.Sharp.IconButton();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipoVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComprovante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipoComp = new System.Windows.Forms.TextBox();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.gbVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenda,
            this.DataVenda,
            this.TipoVenda,
            this.Total,
            this.Cliente,
            this.Vendedor});
            this.dgVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVendas.Location = new System.Drawing.Point(12, 86);
            this.dgVendas.MultiSelect = false;
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.ReadOnly = true;
            this.dgVendas.RowHeadersVisible = false;
            this.dgVendas.RowTemplate.Height = 28;
            this.dgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendas.Size = new System.Drawing.Size(1014, 297);
            this.dgVendas.TabIndex = 0;
            this.dgVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendas_CellClick);
            this.dgVendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgVendas_CellFormatting);
            // 
            // IdVenda
            // 
            this.IdVenda.DataPropertyName = "IdVenda";
            this.IdVenda.HeaderText = "Id Venda";
            this.IdVenda.Name = "IdVenda";
            this.IdVenda.ReadOnly = true;
            this.IdVenda.Width = 70;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "DataVenda";
            this.DataVenda.HeaderText = "Data";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            this.DataVenda.Width = 120;
            // 
            // TipoVenda
            // 
            this.TipoVenda.DataPropertyName = "TipoVenda";
            this.TipoVenda.HeaderText = "Tipo";
            this.TipoVenda.Name = "TipoVenda";
            this.TipoVenda.ReadOnly = true;
            this.TipoVenda.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Valor";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 140;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCli";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "NomeVendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Procurar Cliente / Vendedor :";
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(983, 47);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 45;
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
            this.btnPesquisar.Location = new System.Drawing.Point(936, 47);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 44;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(229, 47);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(699, 29);
            this.tbPesq.TabIndex = 43;
            // 
            // tbValFiltroIni
            // 
            this.tbValFiltroIni.Location = new System.Drawing.Point(350, 6);
            this.tbValFiltroIni.Name = "tbValFiltroIni";
            this.tbValFiltroIni.Size = new System.Drawing.Size(100, 29);
            this.tbValFiltroIni.TabIndex = 51;
            this.tbValFiltroIni.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Filtrar Vendas :";
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Data",
            "Tipo Venda",
            "Valor da Venda"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(147, 6);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(143, 29);
            this.cbTipoFiltro.TabIndex = 48;
            this.cbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbTipoFiltro_SelectedIndexChanged);
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
            this.btnFiltrar.Location = new System.Drawing.Point(296, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnFiltrar.Size = new System.Drawing.Size(41, 29);
            this.btnFiltrar.TabIndex = 47;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tbValFiltroFin
            // 
            this.tbValFiltroFin.Location = new System.Drawing.Point(473, 5);
            this.tbValFiltroFin.Name = "tbValFiltroFin";
            this.tbValFiltroFin.Size = new System.Drawing.Size(100, 29);
            this.tbValFiltroFin.TabIndex = 54;
            this.tbValFiltroFin.Visible = false;
            // 
            // dtpDataIni
            // 
            this.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIni.Location = new System.Drawing.Point(596, 5);
            this.dtpDataIni.Name = "dtpDataIni";
            this.dtpDataIni.Size = new System.Drawing.Size(123, 29);
            this.dtpDataIni.TabIndex = 55;
            this.dtpDataIni.Visible = false;
            // 
            // dtpDataFin
            // 
            this.dtpDataFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFin.Location = new System.Drawing.Point(646, 5);
            this.dtpDataFin.Name = "dtpDataFin";
            this.dtpDataFin.Size = new System.Drawing.Size(123, 29);
            this.dtpDataFin.TabIndex = 56;
            this.dtpDataFin.Visible = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(965, 2);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(52, 21);
            this.lblInicio.TabIndex = 57;
            this.lblInicio.Text = "label9";
            this.lblInicio.Visible = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(965, 23);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(61, 21);
            this.lblFinal.TabIndex = 58;
            this.lblFinal.Text = "label11";
            this.lblFinal.Visible = false;
            // 
            // cbTipoVenda
            // 
            this.cbTipoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVenda.FormattingEnabled = true;
            this.cbTipoVenda.Items.AddRange(new object[] {
            "Balcão",
            "Internet",
            "Telefone",
            "WhatsApp",
            "Serviço"});
            this.cbTipoVenda.Location = new System.Drawing.Point(785, 5);
            this.cbTipoVenda.Name = "cbTipoVenda";
            this.cbTipoVenda.Size = new System.Drawing.Size(143, 29);
            this.cbTipoVenda.TabIndex = 59;
            this.cbTipoVenda.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Comprovante";
            // 
            // tbDataVenda
            // 
            this.tbDataVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDataVenda.Location = new System.Drawing.Point(20, 46);
            this.tbDataVenda.Name = "tbDataVenda";
            this.tbDataVenda.ReadOnly = true;
            this.tbDataVenda.Size = new System.Drawing.Size(162, 29);
            this.tbDataVenda.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data da Venda";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cliente";
            // 
            // gbVendas
            // 
            this.gbVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVendas.BackColor = System.Drawing.Color.LightGray;
            this.gbVendas.Controls.Add(this.btnItensVenda);
            this.gbVendas.Controls.Add(this.tbValorTotal);
            this.gbVendas.Controls.Add(this.label7);
            this.gbVendas.Controls.Add(this.tbTipoVenda);
            this.gbVendas.Controls.Add(this.label5);
            this.gbVendas.Controls.Add(this.tbComprovante);
            this.gbVendas.Controls.Add(this.label3);
            this.gbVendas.Controls.Add(this.tbTipoComp);
            this.gbVendas.Controls.Add(this.tbVendedor);
            this.gbVendas.Controls.Add(this.tbCliente);
            this.gbVendas.Controls.Add(this.label10);
            this.gbVendas.Controls.Add(this.label6);
            this.gbVendas.Controls.Add(this.tbDataVenda);
            this.gbVendas.Controls.Add(this.label4);
            this.gbVendas.Controls.Add(this.label2);
            this.gbVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVendas.Location = new System.Drawing.Point(12, 402);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(815, 185);
            this.gbVendas.TabIndex = 53;
            this.gbVendas.TabStop = false;
            // 
            // btnItensVenda
            // 
            this.btnItensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItensVenda.FlatAppearance.BorderSize = 0;
            this.btnItensVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensVenda.ForeColor = System.Drawing.Color.Black;
            this.btnItensVenda.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btnItensVenda.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnItensVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnItensVenda.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnItensVenda.Location = new System.Drawing.Point(668, 126);
            this.btnItensVenda.Name = "btnItensVenda";
            this.btnItensVenda.Size = new System.Drawing.Size(141, 53);
            this.btnItensVenda.TabIndex = 41;
            this.btnItensVenda.Text = "Itens da Venda";
            this.btnItensVenda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnItensVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItensVenda.UseVisualStyleBackColor = true;
            this.btnItensVenda.Click += new System.EventHandler(this.btnItensVenda_Click);
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorTotal.Location = new System.Drawing.Point(382, 139);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.ReadOnly = true;
            this.tbValorTotal.Size = new System.Drawing.Size(162, 29);
            this.tbValorTotal.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valor Total";
            // 
            // tbTipoVenda
            // 
            this.tbTipoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTipoVenda.Location = new System.Drawing.Point(20, 139);
            this.tbTipoVenda.Name = "tbTipoVenda";
            this.tbTipoVenda.ReadOnly = true;
            this.tbTipoVenda.Size = new System.Drawing.Size(162, 29);
            this.tbTipoVenda.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tipo Venda";
            // 
            // tbComprovante
            // 
            this.tbComprovante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbComprovante.Location = new System.Drawing.Point(564, 46);
            this.tbComprovante.Name = "tbComprovante";
            this.tbComprovante.ReadOnly = true;
            this.tbComprovante.Size = new System.Drawing.Size(162, 29);
            this.tbComprovante.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Numero Comprovante";
            // 
            // tbTipoComp
            // 
            this.tbTipoComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTipoComp.Location = new System.Drawing.Point(382, 46);
            this.tbTipoComp.Name = "tbTipoComp";
            this.tbTipoComp.ReadOnly = true;
            this.tbTipoComp.Size = new System.Drawing.Size(162, 29);
            this.tbTipoComp.TabIndex = 34;
            // 
            // tbVendedor
            // 
            this.tbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbVendedor.Location = new System.Drawing.Point(201, 139);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.ReadOnly = true;
            this.tbVendedor.Size = new System.Drawing.Size(162, 29);
            this.tbVendedor.TabIndex = 33;
            // 
            // tbCliente
            // 
            this.tbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCliente.Location = new System.Drawing.Point(199, 46);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(162, 29);
            this.tbCliente.TabIndex = 32;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.cbTipoVenda);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpDataFin);
            this.Controls.Add(this.dtpDataIni);
            this.Controls.Add(this.tbValFiltroFin);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.tbValFiltroIni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbPesq);
            this.Controls.Add(this.dgVendas);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.gbVendas.ResumeLayout(false);
            this.gbVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.TextBox tbPesq;
        private System.Windows.Forms.TextBox tbValFiltroIni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbValFiltroFin;
        private System.Windows.Forms.DateTimePicker dtpDataIni;
        private System.Windows.Forms.DateTimePicker dtpDataFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.ComboBox cbTipoVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDataVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTipoVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComprovante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipoComp;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.TextBox tbCliente;
        private FontAwesome.Sharp.IconButton btnItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
    }
}