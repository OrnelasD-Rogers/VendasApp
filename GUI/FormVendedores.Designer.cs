
namespace GUI
{
    partial class FormVendedores
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtbWhatsApp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimparVendedor = new FontAwesome.Sharp.IconButton();
            this.btnAddVendedor = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btnNovoVendedor = new FontAwesome.Sharp.IconButton();
            this.btnEditarVendedor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhatsApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCliente.SuspendLayout();
            this.gbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.BackColor = System.Drawing.Color.LightGray;
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.cbSexo);
            this.gbCliente.Controls.Add(this.mtbWhatsApp);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.mtbTelefone);
            this.gbCliente.Controls.Add(this.tbEmail);
            this.gbCliente.Controls.Add(this.btnCancelar);
            this.gbCliente.Controls.Add(this.label10);
            this.gbCliente.Controls.Add(this.btnLimparVendedor);
            this.gbCliente.Controls.Add(this.btnAddVendedor);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.tbVendedor);
            this.gbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCliente.Location = new System.Drawing.Point(12, 394);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(912, 223);
            this.gbCliente.TabIndex = 51;
            this.gbCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(323, 74);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(188, 29);
            this.cbSexo.TabIndex = 32;
            // 
            // mtbWhatsApp
            // 
            this.mtbWhatsApp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbWhatsApp.Location = new System.Drawing.Point(727, 74);
            this.mtbWhatsApp.Name = "mtbWhatsApp";
            this.mtbWhatsApp.Size = new System.Drawing.Size(175, 29);
            this.mtbWhatsApp.TabIndex = 29;
            this.mtbWhatsApp.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbWhatsApp.Leave += new System.EventHandler(this.mtbWhatsApp_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "(DDD) + WhatsApp";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Location = new System.Drawing.Point(532, 74);
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(175, 29);
            this.mtbTelefone.TabIndex = 27;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmail.Location = new System.Drawing.Point(27, 156);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(275, 29);
            this.tbEmail.TabIndex = 26;
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
            this.btnCancelar.Location = new System.Drawing.Point(880, 0);
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
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "(DDD) + Telefone";
            // 
            // btnLimparVendedor
            // 
            this.btnLimparVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparVendedor.FlatAppearance.BorderSize = 0;
            this.btnLimparVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparVendedor.ForeColor = System.Drawing.Color.Black;
            this.btnLimparVendedor.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparVendedor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparVendedor.Location = new System.Drawing.Point(579, 143);
            this.btnLimparVendedor.Name = "btnLimparVendedor";
            this.btnLimparVendedor.Size = new System.Drawing.Size(141, 53);
            this.btnLimparVendedor.TabIndex = 22;
            this.btnLimparVendedor.Text = "Limpar Campos";
            this.btnLimparVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparVendedor.UseVisualStyleBackColor = true;
            this.btnLimparVendedor.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // btnAddVendedor
            // 
            this.btnAddVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVendedor.FlatAppearance.BorderSize = 0;
            this.btnAddVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVendedor.ForeColor = System.Drawing.Color.Black;
            this.btnAddVendedor.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddVendedor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAddVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVendedor.Location = new System.Drawing.Point(726, 143);
            this.btnAddVendedor.Name = "btnAddVendedor";
            this.btnAddVendedor.Size = new System.Drawing.Size(141, 53);
            this.btnAddVendedor.TabIndex = 21;
            this.btnAddVendedor.Text = "Cadastrar Vendedor";
            this.btnAddVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddVendedor.UseVisualStyleBackColor = true;
            this.btnAddVendedor.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome";
            // 
            // tbVendedor
            // 
            this.tbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbVendedor.Location = new System.Drawing.Point(27, 74);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(275, 29);
            this.tbVendedor.TabIndex = 11;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.gbBotoes.Controls.Add(this.btnNovoVendedor);
            this.gbBotoes.Controls.Add(this.btnEditarVendedor);
            this.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBotoes.Location = new System.Drawing.Point(12, 328);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(313, 60);
            this.gbBotoes.TabIndex = 50;
            this.gbBotoes.TabStop = false;
            // 
            // btnNovoVendedor
            // 
            this.btnNovoVendedor.FlatAppearance.BorderSize = 0;
            this.btnNovoVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoVendedor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoVendedor.ForeColor = System.Drawing.Color.Black;
            this.btnNovoVendedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNovoVendedor.IconColor = System.Drawing.Color.Green;
            this.btnNovoVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovoVendedor.IconSize = 35;
            this.btnNovoVendedor.Location = new System.Drawing.Point(0, 0);
            this.btnNovoVendedor.Name = "btnNovoVendedor";
            this.btnNovoVendedor.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnNovoVendedor.Size = new System.Drawing.Size(143, 56);
            this.btnNovoVendedor.TabIndex = 26;
            this.btnNovoVendedor.Text = "Novo Vendedor";
            this.btnNovoVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoVendedor.UseVisualStyleBackColor = true;
            this.btnNovoVendedor.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnEditarVendedor
            // 
            this.btnEditarVendedor.FlatAppearance.BorderSize = 0;
            this.btnEditarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVendedor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVendedor.ForeColor = System.Drawing.Color.Black;
            this.btnEditarVendedor.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarVendedor.IconColor = System.Drawing.Color.DimGray;
            this.btnEditarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarVendedor.IconSize = 35;
            this.btnEditarVendedor.Location = new System.Drawing.Point(149, 0);
            this.btnEditarVendedor.Name = "btnEditarVendedor";
            this.btnEditarVendedor.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnEditarVendedor.Size = new System.Drawing.Size(143, 56);
            this.btnEditarVendedor.TabIndex = 27;
            this.btnEditarVendedor.Text = "Editar Selecionado";
            this.btnEditarVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarVendedor.UseVisualStyleBackColor = true;
            this.btnEditarVendedor.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Procurar Vendedor :";
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(985, 39);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 48;
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
            this.btnPesquisar.Location = new System.Drawing.Point(938, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(163, 39);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(769, 29);
            this.tbPesq.TabIndex = 46;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVendedor,
            this.Nome,
            this.Sexo,
            this.Email,
            this.Telefone,
            this.WhatsApp});
            this.dgClientes.Location = new System.Drawing.Point(12, 74);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.RowTemplate.Height = 28;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(1014, 248);
            this.dgClientes.TabIndex = 45;
            this.dgClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgClientes_CellFormatting);
            // 
            // IdVendedor
            // 
            this.IdVendedor.DataPropertyName = "IdVendedor";
            this.IdVendedor.HeaderText = "Id Vendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Width = 65;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbPesq);
            this.Controls.Add(this.dgClientes);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVendedores";
            this.Text = "FormVendedores";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mtbWhatsApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnLimparVendedor;
        private FontAwesome.Sharp.IconButton btnAddVendedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.GroupBox gbBotoes;
        private FontAwesome.Sharp.IconButton btnNovoVendedor;
        private FontAwesome.Sharp.IconButton btnEditarVendedor;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.TextBox tbPesq;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhatsApp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}