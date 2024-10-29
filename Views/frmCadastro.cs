using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void habilitarCadastrar()
        {

            if(tbxNome.Text != "" && tbxUsuario.Text != "" && tbxTelefone.Text != "" && tbxSenha.Text.Length > 8 && tbxSenha.Text == tbxConfirm.Text);

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxTelefone_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxConfirm_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = conexaoDb.CriarConexao();

            // abrindo conexao
            conexao.Open();

            // criando o comando pra inserir as informacoes
            string sql = $"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";

            // Criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", tbxNome.Text);
            comando.Parameters.AddWithValue("@usuario", tbxUsuario.Text);
            comando.Parameters.AddWithValue("@telefone", tbxTelefone.Text);
            comando.Parameters.AddWithValue("@senha", tbxSenha.Text);

            // Executando o comando no banco de dados
            comando.ExecuteNonQuery();

            // fechando conexao
            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso!");
            this.Close();
        }
    }
}
