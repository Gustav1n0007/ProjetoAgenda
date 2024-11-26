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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void exibeContatos()
        {
            ContatoController exibeCategorias = new ContatoController();
            DataTable datatable = exibeCategorias.getContatos();
            dgvContatos.DataSource = datatable;
        }
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            exibeContatos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;
            string categoria = txtCategoria.Text;

            ContatoController addUser = new ContatoController();
            addUser.addContato(contato, telefone, categoria);
            exibeContatos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)   
        {
            int id_categoria = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;
            string categoria = txtCategoria.Text;

            ContatoController alteraContato = new ContatoController();
            alteraContato.updateContato(contato, telefone, categoria, id_categoria);
            exibeContatos();
        }
    }
}
