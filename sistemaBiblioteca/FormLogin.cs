using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistemaBiblioteca.banco;

namespace sistemaBiblioteca
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                string sql = @"SELECT * FROM usuarios
                       WHERE matricula = @matricula
                       AND senha = @senha";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@matricula", txtUsuarioLogin.Text);
                comando.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

                MySqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    string tipoUsuario = leitor["tipo"].ToString();

                    MessageBox.Show("Login realizado com sucesso!");

                    FormPrincipal principal = new FormPrincipal(tipoUsuario);
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao realizar login: " + erro.Message);
            }
        }
    }
}
