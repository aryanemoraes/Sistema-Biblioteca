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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text))
            {
                MessageBox.Show("Informe o nome do usuário.");
                return;
            }

            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                string sql = @"INSERT INTO usuarios
                               (nome, matricula, email, telefone, tipo, senha)
                               VALUES
                               (@nome, @matricula, @email, @telefone, @tipo, @senha)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", txtNomeUsuario.Text);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@tipo", cmbTipoUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenhaUsuario.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso!");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + erro.Message);
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulaUsuario_Click(object sender, EventArgs e)
        {
            // pega o que foi digitado na pesquisa
            string pesquisa = txtPesquisarUsuario.Text;

            // abre 
            Conexao banco = new Conexao();
            MySqlConnection conexao = banco.AbrirConexao();

            // SELECT
            string sql = @"SELECT id_usuario, nome, matricula, email, telefone, tipo
               FROM usuarios
               WHERE nome LIKE @pesquisa
               OR email LIKE @pesquisa";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

            // recebe os dados da pesquisa
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            //tabela
            DataTable tabela = new DataTable();

            // coloca os dados na tabela
            adaptador.Fill(tabela);
            dgvUsuarios.DataSource = tabela;

            // fecha a conexao
            conexao.Close();
        }
    }
}
