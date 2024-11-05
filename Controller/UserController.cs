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
    internal class UserController
    {
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                // cria a conexao com o banco de dados
                MySqlConnection conexao = ConexaoDb.CriarConexao();

                // inicia uma conexao 
                conexao.Open();

                // Cria o comando para inserir na tabela do sql
                string sql = "INSERT INTO tbUsuario (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                // comando para colocar o codigo dentro do sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // adiciona os valores certos a tabela
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                // executa o comando dentro do sql
                int linhasAfetadas = comando.ExecuteNonQuery();

                // encerra a conexao
                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    return true;
                }
                else
                {
                    MessageBox.Show("Cadastro negado");
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro.Message}","erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
        }

        public bool logarUser(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDb.CriarConexao();

                string sql = "select * from tbUsuario where binary usuario=@usuario and binary senha =@senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // adiciona os valores certos a tabela
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();


                if (resultado.Read())
                {
                    conexao.Close();
                    MessageBox.Show("login efetuado");
                    frmPrincipal frmTeste = new frmPrincipal();
                    frmTeste.ShowDialog();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Login nao foi efetuado /n Erro: {erro}");
                return false;
            }

        }
    }
}
