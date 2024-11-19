using MySql.Data.MySqlClient;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoAgenda.Data
{
    static internal class ConexaoDb
    {
        static public MySqlConnection CriarConexao()
        {
            // string com os dados para conectar
            string stringConexao = "Server=localhost;Database=dbAgenda;User ID=root;Password=root";

            // conectando
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }

        static public MySqlConnection CriarConexao(string user, string senha)
        {
            string stringConexao = $"server=localhost;Database=dbAgenda;User ID={user};password={senha}";

            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }


}
