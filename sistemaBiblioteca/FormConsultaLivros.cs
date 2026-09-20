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
    public partial class FormConsultaLivros : Form
    {
        public FormConsultaLivros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                // pega o que foi digitado no campo pesquisar
                string pesquisa = txtPesquisarLivro.Text;

                // pesquisa o livro pelo titulo
                string sql = "";

                // verifica se a pesquisa escolhida foi por titulo
                if (cmbTipoPesquisa.Text == "Título")
                {
                    sql = "SELECT * FROM livros WHERE titulo LIKE @pesquisa";
                }

                // verifica a pesquisa 
                else if (cmbTipoPesquisa.Text == "Autor")
                {
                    sql = @"SELECT livros.*
                        FROM livros
                        INNER JOIN autores ON livros.id_autor = autores.id_autor
                        WHERE autores.nome LIKE @pesquisa";
                }

                // verifica se marcou a opção de livros disponíveis
                if (chkSomenteDisponiveis.Checked)
                {
                    sql += " AND quantidade_disponivel > 0";
                }

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // coloca o texto digitado
                comando.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                dgvLivros.DataSource = tabela;

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar livros: " + erro.Message);
            }
        }

        private void txtPesquisarLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
