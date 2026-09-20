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
    public partial class FormLivros : Form
    {
        public FormLivros()
        {
            InitializeComponent();
            CarregarAutores();
        }

        // Carrega os autores cadastrados no banco
        private void CarregarAutores()
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                string sql = "SELECT id_autor, nome FROM autores ORDER BY nome";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                // Mostra o nome do autor
                cmbAutor.DataSource = tabela;
                cmbAutor.DisplayMember = "nome";

                // Guarda o ID do autor
                cmbAutor.ValueMember = "id_autor";

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar autores: " + erro.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAnoPublicacao_Click(object sender, EventArgs e)
        {

        }

        private void lblEditora_Click(object sender, EventArgs e)
        {

        }

        private void txtAnoPublicacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQtdDisponivel_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirLivro_Click(object sender, EventArgs e)
        {
            // verifica se o titulo do livro foi preenchido
            if (string.IsNullOrWhiteSpace(cmbTitulo.Text))
            {
                MessageBox.Show("Informe o título do livro.");
                return;
            }
            // abre a conexao com o banco
            Conexao banco = new Conexao();
            MySqlConnection conexao = banco.AbrirConexao();

            // comando para cadastrar o livro
            string sql = @"INSERT INTO livros
               (titulo, ano_publicacao, editora, quantidade_total,
                quantidade_disponivel, id_autor, status)
               VALUES
               (@titulo, @ano, @editora, @qtdTotal,
                @qtdDisponivel, @autor, @status)";

            // prepara o comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            // pega o titulo informado na tela
            comando.Parameters.AddWithValue("@titulo", cmbTitulo.Text);

            // pega o ano de publicacao
            comando.Parameters.AddWithValue("@ano", txtAnoPublicacao.Text);

            // pega a editora informada
            comando.Parameters.AddWithValue("@editora", txtEditora.Text);

            // pega a quantidade total de livros
            comando.Parameters.AddWithValue("@qtdTotal", txtQuantidadeTotal.Text);

            // pega a quantidade disponivel
            comando.Parameters.AddWithValue("@qtdDisponivel", txtQtdDisponivel.Text);

            // pega o id do autor selecionado
            comando.Parameters.AddWithValue("@autor", cmbAutor.SelectedValue);

            // pega o status selecionado
            comando.Parameters.AddWithValue("@status", cmbStatus.Text);

            // executa o cadastro do livro
            comando.ExecuteNonQuery();

            // informa que o cadastro foi realizado
            MessageBox.Show("Livro cadastrado com sucesso!");

            // fecha a conexao com o banco
            conexao.Close();
        }
    }
}
