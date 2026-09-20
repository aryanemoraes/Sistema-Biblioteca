using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemaBiblioteca.banco
{
    internal class Conexao
    {
     private string stringConexao = "server=localhost;database=biblioteca;uid=root;pwd=;";
        public MySqlConnection AbrirConexao()
        {
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}