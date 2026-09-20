namespace sistemaBiblioteca
{
    partial class FormPrincipal
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.btnAutorPrincipal = new System.Windows.Forms.Button();
            this.btnUsuarioPrincipal = new System.Windows.Forms.Button();
            this.btnLivrosPrincipal = new System.Windows.Forms.Button();
            this.btnEmprePrincipal = new System.Windows.Forms.Button();
            this.btnConsultarLivrosPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.Red;
            this.lblSistema.Location = new System.Drawing.Point(159, 27);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(236, 24);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "SISTEMA DE BIBLIOTECA";
            this.lblSistema.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAutorPrincipal
            // 
            this.btnAutorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAutorPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorPrincipal.Location = new System.Drawing.Point(12, 69);
            this.btnAutorPrincipal.Name = "btnAutorPrincipal";
            this.btnAutorPrincipal.Size = new System.Drawing.Size(181, 31);
            this.btnAutorPrincipal.TabIndex = 1;
            this.btnAutorPrincipal.Text = "AUTORES";
            this.btnAutorPrincipal.UseVisualStyleBackColor = false;
            this.btnAutorPrincipal.Click += new System.EventHandler(this.btnAutorPrincipal_Click);
            // 
            // btnUsuarioPrincipal
            // 
            this.btnUsuarioPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUsuarioPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioPrincipal.Location = new System.Drawing.Point(288, 69);
            this.btnUsuarioPrincipal.Name = "btnUsuarioPrincipal";
            this.btnUsuarioPrincipal.Size = new System.Drawing.Size(173, 31);
            this.btnUsuarioPrincipal.TabIndex = 2;
            this.btnUsuarioPrincipal.Text = "USUÁRIO";
            this.btnUsuarioPrincipal.UseVisualStyleBackColor = false;
            this.btnUsuarioPrincipal.Click += new System.EventHandler(this.btnUsuarioPrincipal_Click);
            // 
            // btnLivrosPrincipal
            // 
            this.btnLivrosPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLivrosPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLivrosPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivrosPrincipal.Location = new System.Drawing.Point(12, 131);
            this.btnLivrosPrincipal.Name = "btnLivrosPrincipal";
            this.btnLivrosPrincipal.Size = new System.Drawing.Size(181, 31);
            this.btnLivrosPrincipal.TabIndex = 3;
            this.btnLivrosPrincipal.Text = "CADASTRAR LIVROS";
            this.btnLivrosPrincipal.UseVisualStyleBackColor = false;
            this.btnLivrosPrincipal.Click += new System.EventHandler(this.btnLivrosPrincipal_Click);
            // 
            // btnEmprePrincipal
            // 
            this.btnEmprePrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmprePrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmprePrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprePrincipal.Location = new System.Drawing.Point(163, 201);
            this.btnEmprePrincipal.Name = "btnEmprePrincipal";
            this.btnEmprePrincipal.Size = new System.Drawing.Size(173, 31);
            this.btnEmprePrincipal.TabIndex = 4;
            this.btnEmprePrincipal.Text = "EMPRÉSTIMOS";
            this.btnEmprePrincipal.UseVisualStyleBackColor = false;
            this.btnEmprePrincipal.Click += new System.EventHandler(this.btnEmprePrincipal_Click);
            // 
            // btnConsultarLivrosPrincipal
            // 
            this.btnConsultarLivrosPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarLivrosPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultarLivrosPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLivrosPrincipal.Location = new System.Drawing.Point(288, 131);
            this.btnConsultarLivrosPrincipal.Name = "btnConsultarLivrosPrincipal";
            this.btnConsultarLivrosPrincipal.Size = new System.Drawing.Size(173, 31);
            this.btnConsultarLivrosPrincipal.TabIndex = 5;
            this.btnConsultarLivrosPrincipal.Text = "CONSULTAR LIVROS";
            this.btnConsultarLivrosPrincipal.UseVisualStyleBackColor = false;
            this.btnConsultarLivrosPrincipal.Click += new System.EventHandler(this.btnConsultarLivrosPrincipal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 287);
            this.Controls.Add(this.btnConsultarLivrosPrincipal);
            this.Controls.Add(this.btnEmprePrincipal);
            this.Controls.Add(this.btnLivrosPrincipal);
            this.Controls.Add(this.btnUsuarioPrincipal);
            this.Controls.Add(this.btnAutorPrincipal);
            this.Controls.Add(this.lblSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Button btnAutorPrincipal;
        private System.Windows.Forms.Button btnUsuarioPrincipal;
        private System.Windows.Forms.Button btnLivrosPrincipal;
        private System.Windows.Forms.Button btnEmprePrincipal;
        private System.Windows.Forms.Button btnConsultarLivrosPrincipal;
    }
}