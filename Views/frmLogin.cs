using ProjetoAgenda.Controller;
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // checa se o tamanho do usuario e senha � maior que o estipulado e habilita o bot�o caso verdadeiro
            if (txtUsuario.TextLength > 0 && txtSenha.TextLength >= 8)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            // dados do usuario em variaveis
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            UserSession.usuario = usuario;
            UserSession.senha = senha;

            // chamando a classe para adicionar ao banco de dados
            UserController logarUser = new UserController();
            // utilizando a classe
            logarUser.logarUser(usuario, senha);
            
            

        }
    }
}
