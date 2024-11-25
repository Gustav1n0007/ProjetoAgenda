using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Controller
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void atualiza_tabela()
        {
            CategoriaController exibeCategorias = new CategoriaController();
            DataTable datatable = exibeCategorias.getCategorias();
            dgvCategoria.DataSource = datatable;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string senha = UserSession.senha;
            string user = UserSession.usuario;
            string categoria = txtCategoria.Text;
            // chamando a classe para adicionar ao banco de dados
            CategoriaController addCategoria = new CategoriaController();
            // utilizando a classe
            addCategoria.addCategoria(categoria, user, senha);

            atualiza_tabela();
        }

        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            atualiza_tabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCategoria_Click(object sender, EventArgs e)
        {
            int id_categoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController removeCategoria = new CategoriaController();
            removeCategoria.removeCategoria(id_categoria);

            atualiza_tabela();
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            string novoNome = txtCategoria.Text;
            int id_categoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController alteraCategoria = new CategoriaController();
            alteraCategoria.updateCategoria(id_categoria, novoNome);
        }
    }
}
