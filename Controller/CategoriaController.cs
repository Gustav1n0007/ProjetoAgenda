using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool addCategoria(string categoria)
        {

            MySqlConnection conexao = null; 

            try
            {
                conexao = ConexaoDb.CriarConexao();
                string sql = "INSERT INTO tbCategoria (categoria) VALUES (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

                int linhasafetadas = comando.ExecuteNonQuery();
                conexao.Close();
                if (linhasafetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            
            finally
            {
                conexao.Close();
            }
        }

        public DataTable getCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDb.CriarConexao();
                string sql = "select id_categoria AS 'Código' ,categoria AS 'Categoria' from tbCategoria;";

                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: " + erro.Message);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
