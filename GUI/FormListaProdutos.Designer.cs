
namespace GUI
{
    partial class FormListaProdutos
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
            this.dgItens = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarProduto = new FontAwesome.Sharp.IconButton();
            this.btnExcluirProduto = new FontAwesome.Sharp.IconButton();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.lblValUn = new System.Windows.Forms.Label();
            this.tbValUn = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItens
            // 
            this.dgItens.AllowUserToAddRows = false;
            this.dgItens.AllowUserToDeleteRows = false;
            this.dgItens.AllowUserToResizeRows = false;
            this.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Produto,
            this.Quantidade,
            this.ValorUnidade,
            this.SubTotal});
            this.dgItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgItens.Location = new System.Drawing.Point(16, 80);
            this.dgItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgItens.MultiSelect = false;
            this.dgItens.Name = "dgItens";
            this.dgItens.ReadOnly = true;
            this.dgItens.RowHeadersVisible = false;
            this.dgItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItens.Size = new System.Drawing.Size(766, 242);
            this.dgItens.TabIndex = 0;
            this.dgItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgItens_CellFormatting);
            this.dgItens.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgItens_CellMouseClick);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id_Produto";
            this.IdProduto.HeaderText = "Id Produto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 320;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnidade
            // 
            this.ValorUnidade.DataPropertyName = "ValorUnidade";
            this.ValorUnidade.HeaderText = "Valor (Un)";
            this.ValorUnidade.Name = "ValorUnidade";
            this.ValorUnidade.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
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
            this.btnEditarProduto.Location = new System.Drawing.Point(13, 397);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnEditarProduto.Size = new System.Drawing.Size(143, 56);
            this.btnEditarProduto.TabIndex = 27;
            this.btnEditarProduto.Text = "Editar Produto";
            this.btnEditarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirProduto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnExcluirProduto.IconColor = System.Drawing.Color.DimGray;
            this.btnExcluirProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirProduto.IconSize = 35;
            this.btnExcluirProduto.Location = new System.Drawing.Point(162, 397);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnExcluirProduto.Size = new System.Drawing.Size(143, 56);
            this.btnExcluirProduto.TabIndex = 28;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // tbProduto
            // 
            this.tbProduto.Enabled = false;
            this.tbProduto.Location = new System.Drawing.Point(26, 33);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(439, 29);
            this.tbProduto.TabIndex = 29;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 9);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(66, 21);
            this.lblProduto.TabIndex = 30;
            this.lblProduto.Text = "Produto";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(472, 9);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(91, 21);
            this.lblQtd.TabIndex = 32;
            this.lblQtd.Text = "Quantidade";
            // 
            // tbQtd
            // 
            this.tbQtd.Enabled = false;
            this.tbQtd.Location = new System.Drawing.Point(485, 33);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(78, 29);
            this.tbQtd.TabIndex = 31;
            this.tbQtd.TextChanged += new System.EventHandler(this.tbQtd_TextChanged);
            // 
            // lblValUn
            // 
            this.lblValUn.AutoSize = true;
            this.lblValUn.Location = new System.Drawing.Point(569, 9);
            this.lblValUn.Name = "lblValUn";
            this.lblValUn.Size = new System.Drawing.Size(81, 21);
            this.lblValUn.TabIndex = 34;
            this.lblValUn.Text = "Valor (Un)";
            // 
            // tbValUn
            // 
            this.tbValUn.Enabled = false;
            this.tbValUn.Location = new System.Drawing.Point(582, 33);
            this.tbValUn.Name = "tbValUn";
            this.tbValUn.Size = new System.Drawing.Size(91, 29);
            this.tbValUn.TabIndex = 33;
            this.tbValUn.TextChanged += new System.EventHandler(this.tbValUn_TextChanged);
            this.tbValUn.Leave += new System.EventHandler(this.tbValUn_Leave);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(678, 9);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(71, 21);
            this.lblSubTotal.TabIndex = 36;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Enabled = false;
            this.tbSubTotal.Location = new System.Drawing.Point(691, 33);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(91, 29);
            this.tbSubTotal.TabIndex = 35;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(658, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 21);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Valor Total";
            this.lblTotal.Visible = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(662, 355);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(119, 29);
            this.tbTotal.TabIndex = 37;
            this.tbTotal.Visible = false;
            // 
            // FormListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(793, 456);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.lblValUn);
            this.Controls.Add(this.tbValUn);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.dgItens);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaProdutos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaProdutos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgItens;
        private FontAwesome.Sharp.IconButton btnEditarProduto;
        private FontAwesome.Sharp.IconButton btnExcluirProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.Label lblValUn;
        private System.Windows.Forms.TextBox tbValUn;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
    }
}