using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBiblioteca
{
    public partial class FormPrincipal : Form
    {
        private string tipoUsuario;

        public FormPrincipal(string tipo)
        {
            InitializeComponent();

            tipoUsuario = tipo;

            if (tipoUsuario == "Administrador")
            {
                btnAutorPrincipal.Enabled = true;
                btnUsuarioPrincipal.Enabled = true;
                btnLivrosPrincipal.Enabled = true;
                btnConsultarLivrosPrincipal.Enabled = true;
                btnEmprePrincipal.Enabled = true;
            }
            else if (tipoUsuario == "Funcionário")
            {
                btnAutorPrincipal.Enabled = true;
                btnUsuarioPrincipal.Enabled = false;
                btnLivrosPrincipal.Enabled = true;
                btnConsultarLivrosPrincipal.Enabled = true;
                btnEmprePrincipal.Enabled = true;
            }
            else if (tipoUsuario == "Aluno")
            {
                btnAutorPrincipal.Enabled = false;
                btnUsuarioPrincipal.Enabled = false;
                btnLivrosPrincipal.Enabled = false;
                btnConsultarLivrosPrincipal.Enabled = true;
                btnEmprePrincipal.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void btnUsuarioPrincipal_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios();
            usuarios.ShowDialog();
        }

        private void btnLivrosPrincipal_Click(object sender, EventArgs e)
        {
            FormLivros livros = new FormLivros();
            livros.ShowDialog();
        }

        private void btnEmprePrincipal_Click(object sender, EventArgs e)
        {
            FormEmprestimos emprestimos = new FormEmprestimos();
            emprestimos.ShowDialog();
        }

        private void btnConsultarLivrosPrincipal_Click(object sender, EventArgs e)
        {
            FormConsultaLivros consultaLivros = new FormConsultaLivros();
            consultaLivros.ShowDialog();
        }

        private void btnAutorPrincipal_Click(object sender, EventArgs e)
        {
            FormAutores autores = new FormAutores();
            autores.ShowDialog();
        }
    }
}
