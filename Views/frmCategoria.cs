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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            // chamando a classe para adicionar ao banco de dados
            CategoriaController addCategoria = new CategoriaController();
            // utilizando a classe
            addCategoria.addCategoria(categoria);
            CategoriaController VerCategorias = new CategoriaController();
            string oi = VerCategorias.viewCategoria();
            listaCategorias.Items.Add(oi);
        }

        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
