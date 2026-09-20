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
    public partial class FormEmprestimos : Form
    {
        public FormEmprestimos()
        {
            InitializeComponent();

            // Carrega os usuários e os livros quando a tela abrir
            CarregarUsuarios();
            CarregarLivros();
        }

        // Busca os usuários cadastrados no banco
        private void CarregarUsuarios()
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                string sql = "SELECT id_usuario, nome FROM usuarios ORDER BY nome";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();

                // Essa parte conecta o resultado da consulta com a tabela
                adaptador.Fill(tabela);

                // Mostra o nome do usuário no ComboBox
                cmbUsuarioEmprestimo.DataSource = tabela;
                cmbUsuarioEmprestimo.DisplayMember = "nome";

                // Guarda o ID do usuário
                cmbUsuarioEmprestimo.ValueMember = "id_usuario";

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar usuários: " + erro.Message);
            }
        }

      
        private void CarregarLivros()
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conexao = banco.AbrirConexao();

                string sql = @"SELECT id_livro, titulo
                             FROM livros
                             ORDER BY titulo";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                // Mostra o título do livro no ComboBox
                cmbLivroEmprestimo.DataSource = tabela;
                cmbLivroEmprestimo.DisplayMember = "titulo";

                // Guarda o ID do livro
                cmbLivroEmprestimo.ValueMember = "id_livro";

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar livros: " + erro.Message);
            }
        }

        private void lblDataEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            // id do usuario selecionado
            int idUsuario = Convert.ToInt32(cmbUsuarioEmprestimo.SelectedValue);

            // id do livro selecionado
            int idLivro = Convert.ToInt32(cmbLivroEmprestimo.SelectedValue);

            // pega a data do emprestimo
            DateTime dataEmprestimo = dtpDataEmprestimo.Value;

            // pega a data prevista para devolucao
            DateTime dataDevolucao = dtpDataDevolucaoPrevista.Value;
            if (dataDevolucao <= dataEmprestimo)
            {
                MessageBox.Show("Devolução deve ser depois da data do empréstimo.");
                return;
            }

            // abre a conexao
            Conexao banco = new Conexao();
            MySqlConnection conexao = banco.AbrirConexao();

            //quantidade disponivel do livro
            string sqlQuantidade = @"SELECT quantidade_disponivel 
                         FROM livros 
                         WHERE id_livro = @idLivro";

            // prepara o comando para consultar a quantidade
            MySqlCommand comandoQuantidade = new MySqlCommand(sqlQuantidade, conexao);

            // informa o livro
            comandoQuantidade.Parameters.AddWithValue("@idLivro", idLivro);

            // guarda a quantidade disponivel
            int quantidadeDisponivel = Convert.ToInt32(comandoQuantidade.ExecuteScalar());

            // verifica se ainda tem livro
            if (quantidadeDisponivel <= 0)
            {
                MessageBox.Show("Livro indisponível para empréstimo.");
                conexao.Close();
                return;
            }
            // prepara o cadastro
            string sqlEmprestimo = @"INSERT INTO emprestimos
                    (id_usuario, id_livro, data_emprestimo, data_prevista, status) VALUES
                    (@idUsuario, @idLivro, @dataEmprestimo, @dataPrevista, @status)";

            // prepara o comando 
            MySqlCommand comandoEmprestimo = new MySqlCommand(sqlEmprestimo, conexao);

            // informa os dados
            comandoEmprestimo.Parameters.AddWithValue("@idUsuario", idUsuario);
            comandoEmprestimo.Parameters.AddWithValue("@idLivro", idLivro);
            comandoEmprestimo.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
            comandoEmprestimo.Parameters.AddWithValue("@dataPrevista", dataDevolucao);

            // informa o status
            comandoEmprestimo.Parameters.AddWithValue("@status", "Emprestado");

            // cadastra o empréstimo no banco
            comandoEmprestimo.ExecuteNonQuery();

            // diminui a unidade 
            string sqlAtualizar = @"UPDATE livros
                        SET quantidade_disponivel = quantidade_disponivel - 1, status = CASE
                        WHEN quantidade_disponivel - 1 <= 0 THEN 'Indisponível'
                        ELSE 'Disponível' END
                        WHERE id_livro = @idLivro";

            //atualizar
            MySqlCommand comandoAtualizar = new MySqlCommand(sqlAtualizar, conexao);

            comandoAtualizar.Parameters.AddWithValue("@idLivro", idLivro);

            // atualiza 
            comandoAtualizar.ExecuteNonQuery();

            // empréstimo foi realizado
            MessageBox.Show("Empréstimo realizado com sucesso!");

            // fecha a conexao com o banco
            conexao.Close();

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // pega o id do livro selecionado
            int idLivro = Convert.ToInt32(cmbLivroEmprestimo.SelectedValue);

            // abre o banco
            Conexao banco = new Conexao();
            MySqlConnection conexao = banco.AbrirConexao();

            // procura o emprestimo do livro
            string sqlEmprestimo = @"SELECT id_emprestimo
                         FROM emprestimos
                         WHERE id_livro = @idLivro
                         AND status = 'Emprestado'";

   
            MySqlCommand comandoEmprestimo = new MySqlCommand(sqlEmprestimo, conexao);

            // informa qual livro procurar
            comandoEmprestimo.Parameters.AddWithValue("@idLivro", idLivro);

            object resultado = comandoEmprestimo.ExecuteScalar();

            // verifica se encontrou o emprestimo
            if (resultado == null)
            {
                MessageBox.Show("Sem emprestimo.Ação inválida.");
                conexao.Close();
                return;
            }
            if (resultado == null)
            {
                MessageBox.Show("Não existe empréstimo para este livro.");
                conexao.Close();
                return;
            }

            
            int idEmprestimo = Convert.ToInt32(resultado);

            // atualiza o emprestimo  UPDATE
            string sqlDevolver = @"UPDATE emprestimos
                       SET data_devolucao = @dataDevolucao,
                           status = 'Devolvido'
                       WHERE id_emprestimo = @idEmprestimo";

            MySqlCommand comandoDevolver = new MySqlCommand(sqlDevolver, conexao);

            
            comandoDevolver.Parameters.AddWithValue("@dataDevolucao", DateTime.Now);
 
            comandoDevolver.Parameters.AddWithValue("@idEmprestimo", idEmprestimo);

            //Devolver o livro e muda o status
            comandoDevolver.ExecuteNonQuery();
            string sqlLivro = @"UPDATE livros
                        SET quantidade_disponivel = quantidade_disponivel + 1,
                        status = 'Disponível'
                        WHERE id_livro = @idLivro"; ;

            MySqlCommand comandoLivro = new MySqlCommand(sqlLivro, conexao);
            comandoLivro.Parameters.AddWithValue("@idLivro", idLivro);

            // atualiza a quantidade do livro
            comandoLivro.ExecuteNonQuery();
            MessageBox.Show("Livro devolvido ");

            // fecha
            conexao.Close();
        }
    }
}