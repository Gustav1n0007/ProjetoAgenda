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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            CategoriaController exibeCategoria = new CategoriaController();
            DataTable categorias = exibeCategoria.getCategorias();
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "categoria";
        }
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            exibeContatos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController exibeCategoria = new CategoriaController();
            DataTable categorias = exibeCategoria.getCategorias();
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "categoria";

            string categoria = comboBox1.Text.ToString();

            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;     

            ContatoController addUser = new ContatoController();
            addUser.addContato(contato, telefone, categoria);
            exibeContatos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CategoriaController exibeCategoria = new CategoriaController();
            DataTable categorias = exibeCategoria.getCategorias();
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "categoria";

            string categoria =  comboBox1.Text.ToString() ?? string.Empty;
            int id_contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;

            ContatoController alteraContato = new ContatoController();
            alteraContato.updateContato(contato, telefone, id_contato, categoria);
            exibeContatos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id_contato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);

            ContatoController delContato = new ContatoController();
            delContato.delContato(id_contato);
            exibeContatos();
        }
    }
}
