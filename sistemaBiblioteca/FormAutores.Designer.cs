namespace sistemaBiblioteca
{
    partial class FormAutores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnInserir;
            this.gInsert = new System.Windows.Forms.GroupBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            btnInserir = new System.Windows.Forms.Button();
            this.gInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnInserir.BackColor = System.Drawing.Color.LightSteelBlue;
            btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnInserir.ForeColor = System.Drawing.Color.Red;
            btnInserir.Location = new System.Drawing.Point(148, 264);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new System.Drawing.Size(148, 29);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gInsert
            // 
            this.gInsert.BackColor = System.Drawing.Color.LightGray;
            this.gInsert.Controls.Add(this.lblAutor);
            this.gInsert.Controls.Add(btnInserir);
            this.gInsert.Controls.Add(this.textBox2);
            this.gInsert.Controls.Add(this.txtNome);
            this.gInsert.Controls.Add(this.lblNacionalidade);
            this.gInsert.Controls.Add(this.lblNome);
            this.gInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gInsert.Location = new System.Drawing.Point(12, 12);
            this.gInsert.Name = "gInsert";
            this.gInsert.Size = new System.Drawing.Size(432, 413);
            this.gInsert.TabIndex = 1;
            this.gInsert.TabStop = false;
            this.gInsert.Text = "INSERT";
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Red;
            this.lblAutor.Location = new System.Drawing.Point(144, 16);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(70, 19);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor(a)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(148, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 24);
            this.textBox2.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.ForeColor = System.Drawing.Color.Blue;
            this.lblNacionalidade.Location = new System.Drawing.Point(0, 214);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(127, 20);
            this.lblNacionalidade.TabIndex = 1;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(6, 160);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FormAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 435);
            this.ControlBox = false;
            this.Controls.Add(this.gInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Autores";
            this.gInsert.ResumeLayout(false);
            this.gInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gInsert;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblAutor;
    }
}

