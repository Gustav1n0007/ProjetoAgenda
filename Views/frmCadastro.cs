using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
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

            if (txtNome.Text != "" && txtUsuario.Text != "" && txtTelefone.Text != "" && txtSenha.Text.Length > 8 && txtSenha.Text == txtRepeteSenha.Text) 
            {
                btnCadastrar.Enabled = true;    
            };

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
            // dados do usuario em variaveis
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;
            string telefone = txtTelefone.Text;
            string senha = txtSenha.Text;

            // chamando a classe para adicionar ao banco de dados
            UserController addUser = new UserController();
            // utilizando a classe
            addUser.AddUser(nome, usuario, telefone, senha);
            this.Close();
        }
    }
}
