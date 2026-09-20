namespace sistemaBiblioteca
{
    partial class FormConsultaLivros
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
            this.lblTituloConsulta = new System.Windows.Forms.Label();
            this.lblPesquisarLivro = new System.Windows.Forms.Label();
            this.txtPesquisarLivro = new System.Windows.Forms.TextBox();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.cmbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.chkSomenteDisponiveis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloConsulta
            // 
            this.lblTituloConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloConsulta.AutoSize = true;
            this.lblTituloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsulta.ForeColor = System.Drawing.Color.Red;
            this.lblTituloConsulta.Location = new System.Drawing.Point(130, 28);
            this.lblTituloConsulta.Name = "lblTituloConsulta";
            this.lblTituloConsulta.Size = new System.Drawing.Size(204, 20);
            this.lblTituloConsulta.TabIndex = 0;
            this.lblTituloConsulta.Text = "CONSULTA DE LIVROS";
            this.lblTituloConsulta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPesquisarLivro
            // 
            this.lblPesquisarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesquisarLivro.AutoSize = true;
            this.lblPesquisarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarLivro.ForeColor = System.Drawing.Color.Blue;
            this.lblPesquisarLivro.Location = new System.Drawing.Point(12, 104);
            this.lblPesquisarLivro.Name = "lblPesquisarLivro";
            this.lblPesquisarLivro.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisarLivro.TabIndex = 1;
            this.lblPesquisarLivro.Text = "Pesquisar:";
            this.lblPesquisarLivro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPesquisarLivro
            // 
            this.txtPesquisarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarLivro.ForeColor = System.Drawing.Color.Red;
            this.txtPesquisarLivro.Location = new System.Drawing.Point(111, 106);
            this.txtPesquisarLivro.Name = "txtPesquisarLivro";
            this.txtPesquisarLivro.Size = new System.Drawing.Size(268, 20);
            this.txtPesquisarLivro.TabIndex = 2;
            this.txtPesquisarLivro.TextChanged += new System.EventHandler(this.txtPesquisarLivro_TextChanged);
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLivro.ForeColor = System.Drawing.Color.Red;
            this.btnPesquisarLivro.Location = new System.Drawing.Point(405, 106);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(108, 27);
            this.btnPesquisarLivro.TabIndex = 3;
            this.btnPesquisarLivro.Text = "CONSULTAR";
            this.btnPesquisarLivro.UseVisualStyleBackColor = false;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoPesquisa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTipoPesquisa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "Título",
            "Autor"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(111, 150);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(268, 25);
            this.cmbTipoPesquisa.TabIndex = 4;
            this.cmbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPesquisa_SelectedIndexChanged);
            // 
            // dgvLivros
            // 
            this.dgvLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(93, 237);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(323, 150);
            this.dgvLivros.TabIndex = 5;
            // 
            // chkSomenteDisponiveis
            // 
            this.chkSomenteDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSomenteDisponiveis.AutoSize = true;
            this.chkSomenteDisponiveis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSomenteDisponiveis.Location = new System.Drawing.Point(186, 198);
            this.chkSomenteDisponiveis.Name = "chkSomenteDisponiveis";
            this.chkSomenteDisponiveis.Size = new System.Drawing.Size(128, 18);
            this.chkSomenteDisponiveis.TabIndex = 6;
            this.chkSomenteDisponiveis.Text = "Livros disponíveis";
            this.chkSomenteDisponiveis.UseVisualStyleBackColor = true;
            // 
            // FormConsultaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(536, 398);
            this.ControlBox = false;
            this.Controls.Add(this.chkSomenteDisponiveis);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.btnPesquisarLivro);
            this.Controls.Add(this.txtPesquisarLivro);
            this.Controls.Add(this.lblPesquisarLivro);
            this.Controls.Add(this.lblTituloConsulta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaLivros";
            this.Text = "Consultar Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloConsulta;
        private System.Windows.Forms.Label lblPesquisarLivro;
        private System.Windows.Forms.TextBox txtPesquisarLivro;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.ComboBox cmbTipoPesquisa;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.CheckBox chkSomenteDisponiveis;
    }
}