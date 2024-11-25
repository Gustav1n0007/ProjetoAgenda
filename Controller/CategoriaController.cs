using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
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
        public bool addCategoria(string categoria, string user, string senha)
        {

            MySqlConnection conexao = null;
            
            try
            {
                conexao = ConexaoDb.CriarConexao(UserSession.usuario, UserSession.senha);
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
                string sql = $"select id_categoria AS 'Código' ,categoria AS 'Categoria', usuario from tbCategoria where usuario = '{UserSession.usuario}@localhost';";

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

        public bool removeCategoria(int id_categoria)
        {
            MySqlConnection conexao = ConexaoDb.CriarConexao(UserSession.usuario, UserSession.senha);

            string sql = "delete from tbCategoria where id_categoria = @id_categoria";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id_categoria", id_categoria);
            int linhasAfetadas = comando.ExecuteNonQuery();

            // encerra a conexao
            conexao.Close();

            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Removido com sucesso");
                return true;
            }
            else
            {
                MessageBox.Show("Remoção negado");
                return false;
            }
        }

        public bool updateCategoria(int id_categoria, string novoCategoria)
        {
            MySqlConnection conexao = ConexaoDb.CriarConexao(UserSession.usuario, UserSession.senha);

            string sql = $"update tbCategoria Set categoria = @novoCategoria where id_categoria = {id_categoria};";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@novoCategoria", novoCategoria);
            int linhasAfetadas = comando.ExecuteNonQuery();

            // encerra a conexao
            conexao.Close();

            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Alterado com sucesso");
                return true;
            }
            else
            {
                MessageBox.Show("Alteração negado");
                return false;
            }
        }
    }
}
