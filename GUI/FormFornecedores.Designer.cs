
namespace GUI
{
    partial class FormFornecedores
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
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.IdFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhatsApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.btnNovoFornecedor = new FontAwesome.Sharp.IconButton();
            this.btnEditarFornecedor = new FontAwesome.Sharp.IconButton();
            this.gbFornecedores = new System.Windows.Forms.GroupBox();
            this.mtbWhatsApp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimparFornecedor = new FontAwesome.Sharp.IconButton();
            this.btnAddFornecedor = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.btnVoltarPesq = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesq = new System.Windows.Forms.TextBox();
            this.cbTipoPesq = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.gbBotoes.SuspendLayout();
            this.gbFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AllowUserToDeleteRows = false;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFornecedor,
            this.Fornecedor,
            this.Telefone,
            this.WhatsApp,
            this.Email});
            this.dgFornecedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgFornecedores.Location = new System.Drawing.Point(30, 97);
            this.dgFornecedores.MultiSelect = false;
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.ReadOnly = true;
            this.dgFornecedores.RowHeadersVisible = false;
            this.dgFornecedores.RowTemplate.Height = 28;
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.Size = new System.Drawing.Size(977, 234);
            this.dgFornecedores.TabIndex = 0;
            this.dgFornecedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFornecedores_CellFormatting);
            // 
            // IdFornecedor
            // 
            this.IdFornecedor.DataPropertyName = "IdFornecedor";
            this.IdFornecedor.HeaderText = "Id Fornecedor";
            this.IdFornecedor.Name = "IdFornecedor";
            this.IdFornecedor.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 260;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 180;
            // 
            // WhatsApp
            // 
            this.WhatsApp.DataPropertyName = "WhatsApp";
            this.WhatsApp.HeaderText = "WhatsApp";
            this.WhatsApp.Name = "WhatsApp";
            this.WhatsApp.ReadOnly = true;
            this.WhatsApp.Width = 180;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 240;
            // 
            // gbBotoes
            // 
            this.gbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBotoes.BackColor = System.Drawing.Color.Gainsboro;
            this.gbBotoes.Controls.Add(this.btnNovoFornecedor);
            this.gbBotoes.Controls.Add(this.btnEditarFornecedor);
            this.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBotoes.Location = new System.Drawing.Point(30, 337);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(313, 69);
            this.gbBotoes.TabIndex = 30;
            this.gbBotoes.TabStop = false;
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.FlatAppearance.BorderSize = 0;
            this.btnNovoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoFornecedor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnNovoFornecedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNovoFornecedor.IconColor = System.Drawing.Color.Green;
            this.btnNovoFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovoFornecedor.IconSize = 35;
            this.btnNovoFornecedor.Location = new System.Drawing.Point(0, 0);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnNovoFornecedor.Size = new System.Drawing.Size(143, 56);
            this.btnNovoFornecedor.TabIndex = 26;
            this.btnNovoFornecedor.Text = "Novo Fornecedor";
            this.btnNovoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnEditarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFornecedor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnEditarFornecedor.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarFornecedor.IconColor = System.Drawing.Color.DimGray;
            this.btnEditarFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarFornecedor.IconSize = 35;
            this.btnEditarFornecedor.Location = new System.Drawing.Point(149, 0);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnEditarFornecedor.Size = new System.Drawing.Size(143, 56);
            this.btnEditarFornecedor.TabIndex = 27;
            this.btnEditarFornecedor.Text = "Editar Selecionado";
            this.btnEditarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarFornecedor.UseVisualStyleBackColor = true;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // gbFornecedores
            // 
            this.gbFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFornecedores.BackColor = System.Drawing.Color.LightGray;
            this.gbFornecedores.Controls.Add(this.mtbWhatsApp);
            this.gbFornecedores.Controls.Add(this.label2);
            this.gbFornecedores.Controls.Add(this.mtbTelefone);
            this.gbFornecedores.Controls.Add(this.tbEmail);
            this.gbFornecedores.Controls.Add(this.btnCancelar);
            this.gbFornecedores.Controls.Add(this.label10);
            this.gbFornecedores.Controls.Add(this.btnLimparFornecedor);
            this.gbFornecedores.Controls.Add(this.btnAddFornecedor);
            this.gbFornecedores.Controls.Add(this.label7);
            this.gbFornecedores.Controls.Add(this.label6);
            this.gbFornecedores.Controls.Add(this.tbFornecedor);
            this.gbFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFornecedores.Location = new System.Drawing.Point(30, 412);
            this.gbFornecedores.Name = "gbFornecedores";
            this.gbFornecedores.Size = new System.Drawing.Size(912, 223);
            this.gbFornecedores.TabIndex = 31;
            this.gbFornecedores.TabStop = false;
            // 
            // mtbWhatsApp
            // 
            this.mtbWhatsApp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbWhatsApp.Location = new System.Drawing.Point(323, 140);
            this.mtbWhatsApp.Name = "mtbWhatsApp";
            this.mtbWhatsApp.Size = new System.Drawing.Size(188, 29);
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
            this.label2.Location = new System.Drawing.Point(319, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "(DDD) + WhatsApp";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Location = new System.Drawing.Point(323, 74);
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(188, 29);
            this.mtbTelefone.TabIndex = 27;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmail.Location = new System.Drawing.Point(27, 140);
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
            this.label10.Location = new System.Drawing.Point(319, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "(DDD) + Telefone";
            // 
            // btnLimparFornecedor
            // 
            this.btnLimparFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLimparFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnLimparFornecedor.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparFornecedor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFornecedor.Location = new System.Drawing.Point(603, 143);
            this.btnLimparFornecedor.Name = "btnLimparFornecedor";
            this.btnLimparFornecedor.Size = new System.Drawing.Size(141, 53);
            this.btnLimparFornecedor.TabIndex = 22;
            this.btnLimparFornecedor.Text = "Limpar Campos";
            this.btnLimparFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparFornecedor.UseVisualStyleBackColor = true;
            this.btnLimparFornecedor.Click += new System.EventHandler(this.btnLimparFornecedor_Click);
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnAddFornecedor.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddFornecedor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAddFornecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFornecedor.Location = new System.Drawing.Point(750, 143);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(141, 53);
            this.btnAddFornecedor.TabIndex = 21;
            this.btnAddFornecedor.Text = "Cadastrar Fornecedor";
            this.btnAddFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFornecedor.UseVisualStyleBackColor = true;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 116);
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
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fornecedor";
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFornecedor.Location = new System.Drawing.Point(27, 74);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(275, 29);
            this.tbFornecedor.TabIndex = 11;
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
            this.btnVoltarPesq.Location = new System.Drawing.Point(930, 62);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnVoltarPesq.Size = new System.Drawing.Size(41, 29);
            this.btnVoltarPesq.TabIndex = 37;
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
            this.btnPesquisar.Location = new System.Drawing.Point(883, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(41, 29);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Pesquisar Fornecedor  por :";
            // 
            // tbPesq
            // 
            this.tbPesq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesq.Location = new System.Drawing.Point(245, 62);
            this.tbPesq.Name = "tbPesq";
            this.tbPesq.Size = new System.Drawing.Size(632, 29);
            this.tbPesq.TabIndex = 34;
            // 
            // cbTipoPesq
            // 
            this.cbTipoPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPesq.FormattingEnabled = true;
            this.cbTipoPesq.Items.AddRange(new object[] {
            "Id Fornecedor",
            "Fornecedor",
            "Email",
            "Telefone",
            "WhatsApp"});
            this.cbTipoPesq.Location = new System.Drawing.Point(30, 62);
            this.cbTipoPesq.Name = "cbTipoPesq";
            this.cbTipoPesq.Size = new System.Drawing.Size(198, 29);
            this.cbTipoPesq.TabIndex = 38;
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
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1038, 664);
            this.Controls.Add(this.cbTipoPesq);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.gbFornecedores);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesq);
            this.Controls.Add(this.gbBotoes);
            this.Controls.Add(this.dgFornecedores);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.gbBotoes.ResumeLayout(false);
            this.gbFornecedores.ResumeLayout(false);
            this.gbFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.GroupBox gbBotoes;
        private FontAwesome.Sharp.IconButton btnNovoFornecedor;
        private FontAwesome.Sharp.IconButton btnEditarFornecedor;
        private System.Windows.Forms.GroupBox gbFornecedores;
        private System.Windows.Forms.TextBox tbEmail;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnLimparFornecedor;
        private FontAwesome.Sharp.IconButton btnAddFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFornecedor;
        private FontAwesome.Sharp.IconButton btnVoltarPesq;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesq;
        private System.Windows.Forms.ComboBox cbTipoPesq;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbWhatsApp;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhatsApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}