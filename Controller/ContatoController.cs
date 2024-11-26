using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public DataTable getContatos()
        {
            MySqlConnection conexao = ConexaoDb.CriarConexao();
            string sql = $"select id_contato AS ID, contato AS Contato, telefone as Telefone, categoria from tbContato where usuario = '{UserSession.usuario}@localhost';";
            conexao.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }

        public bool addContato(string contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDb.CriarConexao(UserSession.usuario, UserSession.senha);
                string sql = "INSERT INTO tbContato (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
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
        public bool updateContato(string contato, string telefone, string categoria, int id_contato)
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDb.CriarConexao(UserSession.usuario, UserSession.senha);
                string sql = $"update tbcontato set contato = @contato, telefone = @telefone, categoria = @categoria where id_contato = @id_contato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
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
    }
}
