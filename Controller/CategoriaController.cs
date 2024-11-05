using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool addCategoria(string categoria)
        {
            try
            {
                MySqlConnection conexao = ConexaoDb.CriarConexao();

                string sql = "INSERT INTO tbCategoria (categoria) VALUES (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

                int linhasafetadas = comando.ExecuteNonQuery();

                if (linhasafetadas > 0)
                {
                    MessageBox.Show("Categoria adicionada com sucesso");
                    return true;
                }
                else
                {
                    MessageBox.Show("Não");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
        }
        public string viewCategoria()
        {
            string none = "";
            MySqlConnection conexao = ConexaoDb.CriarConexao();

            string sql = "select binary categoria from TbCategoria;";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                string categoria = reader["categoria"].ToString();
                return categoria;
                
            }
            else
            {
                return none;
            }
        }

    }
}
