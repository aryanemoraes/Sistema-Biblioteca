namespace sistemaBiblioteca
{
    partial class FormEmprestimos
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
            this.lblTituloEmprestimo = new System.Windows.Forms.Label();
            this.lblUsuarioEmprestimo = new System.Windows.Forms.Label();
            this.cmbUsuarioEmprestimo = new System.Windows.Forms.ComboBox();
            this.lblLivroEmprestimo = new System.Windows.Forms.Label();
            this.cmbLivroEmprestimo = new System.Windows.Forms.ComboBox();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDevolucao = new System.Windows.Forms.Label();
            this.dtpDataDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloEmprestimo
            // 
            this.lblTituloEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloEmprestimo.AutoSize = true;
            this.lblTituloEmprestimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmprestimo.ForeColor = System.Drawing.Color.Red;
            this.lblTituloEmprestimo.Location = new System.Drawing.Point(117, 45);
            this.lblTituloEmprestimo.Name = "lblTituloEmprestimo";
            this.lblTituloEmprestimo.Size = new System.Drawing.Size(208, 19);
            this.lblTituloEmprestimo.TabIndex = 0;
            this.lblTituloEmprestimo.Text = "EMPRÉSTIMO DE LIVROS";
            // 
            // lblUsuarioEmprestimo
            // 
            this.lblUsuarioEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioEmprestimo.AutoSize = true;
            this.lblUsuarioEmprestimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmprestimo.ForeColor = System.Drawing.Color.Blue;
            this.lblUsuarioEmprestimo.Location = new System.Drawing.Point(164, 102);
            this.lblUsuarioEmprestimo.Name = "lblUsuarioEmprestimo";
            this.lblUsuarioEmprestimo.Size = new System.Drawing.Size(75, 19);
            this.lblUsuarioEmprestimo.TabIndex = 1;
            this.lblUsuarioEmprestimo.Text = "Usuario:";
            // 
            // cmbUsuarioEmprestimo
            // 
            this.cmbUsuarioEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsuarioEmprestimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbUsuarioEmprestimo.FormattingEnabled = true;
            this.cmbUsuarioEmprestimo.Location = new System.Drawing.Point(12, 124);
            this.cmbUsuarioEmprestimo.Name = "cmbUsuarioEmprestimo";
            this.cmbUsuarioEmprestimo.Size = new System.Drawing.Size(440, 21);
            this.cmbUsuarioEmprestimo.TabIndex = 2;
            // 
            // lblLivroEmprestimo
            // 
            this.lblLivroEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLivroEmprestimo.AutoSize = true;
            this.lblLivroEmprestimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroEmprestimo.ForeColor = System.Drawing.Color.Blue;
            this.lblLivroEmprestimo.Location = new System.Drawing.Point(175, 161);
            this.lblLivroEmprestimo.Name = "lblLivroEmprestimo";
            this.lblLivroEmprestimo.Size = new System.Drawing.Size(54, 19);
            this.lblLivroEmprestimo.TabIndex = 3;
            this.lblLivroEmprestimo.Text = "Livro:";
            // 
            // cmbLivroEmprestimo
            // 
            this.cmbLivroEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLivroEmprestimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbLivroEmprestimo.FormattingEnabled = true;
            this.cmbLivroEmprestimo.Location = new System.Drawing.Point(12, 183);
            this.cmbLivroEmprestimo.Name = "cmbLivroEmprestimo";
            this.cmbLivroEmprestimo.Size = new System.Drawing.Size(440, 21);
            this.cmbLivroEmprestimo.TabIndex = 4;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmprestimo.ForeColor = System.Drawing.Color.Blue;
            this.lblDataEmprestimo.Location = new System.Drawing.Point(12, 235);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(170, 19);
            this.lblDataEmprestimo.TabIndex = 5;
            this.lblDataEmprestimo.Text = "Data do Empréstimo:";
            this.lblDataEmprestimo.Click += new System.EventHandler(this.lblDataEmprestimo_Click);
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataEmprestimo.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpDataEmprestimo.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpDataEmprestimo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(193, 235);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(200, 21);
            this.dtpDataEmprestimo.TabIndex = 6;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDevolucao.AutoSize = true;
            this.dtpDataDevolucao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDevolucao.ForeColor = System.Drawing.Color.Blue;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(12, 291);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(175, 19);
            this.dtpDataDevolucao.TabIndex = 7;
            this.dtpDataDevolucao.Text = "Data Para Devolução:";
            // 
            // dtpDataDevolucaoPrevista
            // 
            this.dtpDataDevolucaoPrevista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDevolucaoPrevista.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpDataDevolucaoPrevista.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpDataDevolucaoPrevista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDevolucaoPrevista.Location = new System.Drawing.Point(193, 291);
            this.dtpDataDevolucaoPrevista.Name = "dtpDataDevolucaoPrevista";
            this.dtpDataDevolucaoPrevista.Size = new System.Drawing.Size(200, 21);
            this.dtpDataDevolucaoPrevista.TabIndex = 8;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmprestimo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmprestimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.Color.Red;
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 352);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(215, 29);
            this.btnEmprestimo.TabIndex = 9;
            this.btnEmprestimo.Text = "REALIZAR EMPRÉSTIMO";
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDevolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.Red;
            this.btnDevolver.Location = new System.Drawing.Point(237, 352);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(215, 29);
            this.btnDevolver.TabIndex = 10;
            this.btnDevolver.Text = "DEVOLVER LIVRO";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // FormEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.dtpDataDevolucaoPrevista);
            this.Controls.Add(this.dtpDataDevolucao);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.cmbLivroEmprestimo);
            this.Controls.Add(this.lblLivroEmprestimo);
            this.Controls.Add(this.cmbUsuarioEmprestimo);
            this.Controls.Add(this.lblUsuarioEmprestimo);
            this.Controls.Add(this.lblTituloEmprestimo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEmprestimo;
        private System.Windows.Forms.Label lblUsuarioEmprestimo;
        private System.Windows.Forms.ComboBox cmbUsuarioEmprestimo;
        private System.Windows.Forms.Label lblLivroEmprestimo;
        private System.Windows.Forms.ComboBox cmbLivroEmprestimo;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label dtpDataDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucaoPrevista;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnDevolver;
    }
}