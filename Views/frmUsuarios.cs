using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void atualiza_tabela()
        {
            CategoriaController GetUsers = new CategoriaController();
            DataTable tabela = GetUsers.getusers();
            dgvUsers.DataSource = tabela;
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            atualiza_tabela();
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            UserController delUser = new UserController();
            delUser.deleteUser(user);
            atualiza_tabela();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            UserController alteraSenha = new UserController();
            alteraSenha.alteraSenha(user, txtNovaSenha.Text);
        }
    }
}
