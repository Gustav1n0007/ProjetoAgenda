using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda.VariableGlobal
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            UserSession.usuario = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }
    }
}
