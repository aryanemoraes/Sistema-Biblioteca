namespace sistemaBiblioteca
{
    partial class FormLivros
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
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTituloCadastro = new System.Windows.Forms.Label();
            this.cmbTitulo = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblAnoPublicacao = new System.Windows.Forms.Label();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.txtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.lblQtdDisponivel = new System.Windows.Forms.Label();
            this.txtQtdDisponivel = new System.Windows.Forms.TextBox();
            this.lblStatusCadastro = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnInserirLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloLivro.ForeColor = System.Drawing.Color.Red;
            this.lblTituloLivro.Location = new System.Drawing.Point(121, 33);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(191, 19);
            this.lblTituloLivro.TabIndex = 0;
            this.lblTituloLivro.Text = "CADASTRO DE LIVROS";
            this.lblTituloLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAutor
            // 
            this.cmbAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(176, 119);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(275, 21);
            this.cmbAutor.TabIndex = 1;
            this.cmbAutor.SelectedIndexChanged += new System.EventHandler(this.cmbAutor_SelectedIndexChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.Blue;
            this.lblAutor.Location = new System.Drawing.Point(13, 118);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(57, 19);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCadastro.AutoSize = true;
            this.lblTituloCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloCadastro.ForeColor = System.Drawing.Color.Blue;
            this.lblTituloCadastro.Location = new System.Drawing.Point(12, 83);
            this.lblTituloCadastro.Name = "lblTituloCadastro";
            this.lblTituloCadastro.Size = new System.Drawing.Size(58, 19);
            this.lblTituloCadastro.TabIndex = 3;
            this.lblTituloCadastro.Text = "Titulo:";
            this.lblTituloCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTitulo.Location = new System.Drawing.Point(176, 82);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(275, 20);
            this.cmbTitulo.TabIndex = 4;
            // 
            // lblEditora
            // 
            this.lblEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditora.ForeColor = System.Drawing.Color.Blue;
            this.lblEditora.Location = new System.Drawing.Point(13, 153);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(70, 19);
            this.lblEditora.TabIndex = 5;
            this.lblEditora.Text = "Editora:";
            this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditora.Click += new System.EventHandler(this.lblEditora_Click);
            // 
            // txtEditora
            // 
            this.txtEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditora.Location = new System.Drawing.Point(176, 154);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(275, 20);
            this.txtEditora.TabIndex = 6;
            this.txtEditora.TextChanged += new System.EventHandler(this.txtEditora_TextChanged);
            // 
            // lblAnoPublicacao
            // 
            this.lblAnoPublicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnoPublicacao.AutoSize = true;
            this.lblAnoPublicacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnoPublicacao.ForeColor = System.Drawing.Color.Blue;
            this.lblAnoPublicacao.Location = new System.Drawing.Point(12, 191);
            this.lblAnoPublicacao.Name = "lblAnoPublicacao";
            this.lblAnoPublicacao.Size = new System.Drawing.Size(158, 19);
            this.lblAnoPublicacao.TabIndex = 7;
            this.lblAnoPublicacao.Text = "Ano de Publicação:";
            this.lblAnoPublicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnoPublicacao.Click += new System.EventHandler(this.lblAnoPublicacao_Click);
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnoPublicacao.Location = new System.Drawing.Point(176, 190);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(275, 20);
            this.txtAnoPublicacao.TabIndex = 8;
            this.txtAnoPublicacao.TextChanged += new System.EventHandler(this.txtAnoPublicacao_TextChanged);
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidadeTotal.AutoSize = true;
            this.lblQuantidadeTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(13, 232);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(144, 19);
            this.lblQuantidadeTotal.TabIndex = 9;
            this.lblQuantidadeTotal.Text = "Quantidade Total:";
            this.lblQuantidadeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(244, 231);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(207, 20);
            this.txtQuantidadeTotal.TabIndex = 10;
            // 
            // lblQtdDisponivel
            // 
            this.lblQtdDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtdDisponivel.AutoSize = true;
            this.lblQtdDisponivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblQtdDisponivel.ForeColor = System.Drawing.Color.Blue;
            this.lblQtdDisponivel.Location = new System.Drawing.Point(12, 265);
            this.lblQtdDisponivel.Name = "lblQtdDisponivel";
            this.lblQtdDisponivel.Size = new System.Drawing.Size(188, 19);
            this.lblQtdDisponivel.TabIndex = 11;
            this.lblQtdDisponivel.Text = "Quantidade Disponível:";
            this.lblQtdDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQtdDisponivel.Click += new System.EventHandler(this.lblQtdDisponivel_Click);
            // 
            // txtQtdDisponivel
            // 
            this.txtQtdDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdDisponivel.Location = new System.Drawing.Point(244, 264);
            this.txtQtdDisponivel.Name = "txtQtdDisponivel";
            this.txtQtdDisponivel.Size = new System.Drawing.Size(207, 20);
            this.txtQtdDisponivel.TabIndex = 12;
            // 
            // lblStatusCadastro
            // 
            this.lblStatusCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusCadastro.AutoSize = true;
            this.lblStatusCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusCadastro.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusCadastro.Location = new System.Drawing.Point(13, 302);
            this.lblStatusCadastro.Name = "lblStatusCadastro";
            this.lblStatusCadastro.Size = new System.Drawing.Size(64, 19);
            this.lblStatusCadastro.TabIndex = 13;
            this.lblStatusCadastro.Text = "Status:";
            this.lblStatusCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cmbStatus.Location = new System.Drawing.Point(89, 301);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(207, 21);
            this.cmbStatus.TabIndex = 14;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnInserirLivro
            // 
            this.btnInserirLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserirLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirLivro.ForeColor = System.Drawing.Color.Red;
            this.btnInserirLivro.Location = new System.Drawing.Point(344, 292);
            this.btnInserirLivro.Name = "btnInserirLivro";
            this.btnInserirLivro.Size = new System.Drawing.Size(107, 34);
            this.btnInserirLivro.TabIndex = 15;
            this.btnInserirLivro.Text = "INSERIR";
            this.btnInserirLivro.UseVisualStyleBackColor = false;
            this.btnInserirLivro.Click += new System.EventHandler(this.btnInserirLivro_Click);
            // 
            // FormLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(486, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btnInserirLivro);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatusCadastro);
            this.Controls.Add(this.txtQtdDisponivel);
            this.Controls.Add(this.lblQtdDisponivel);
            this.Controls.Add(this.txtQuantidadeTotal);
            this.Controls.Add(this.lblQuantidadeTotal);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.lblAnoPublicacao);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.cmbTitulo);
            this.Controls.Add(this.lblTituloCadastro);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.lblTituloLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTituloCadastro;
        private System.Windows.Forms.TextBox cmbTitulo;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblAnoPublicacao;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.TextBox txtQuantidadeTotal;
        private System.Windows.Forms.Label lblQtdDisponivel;
        private System.Windows.Forms.TextBox txtQtdDisponivel;
        private System.Windows.Forms.Label lblStatusCadastro;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnInserirLivro;
    }
}