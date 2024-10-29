namespace ProjetoAgenda
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            tbxSenha = new TextBox();
            tbxUsuario = new TextBox();
            btnLogin = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(80, 41);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(98, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(80, 127);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(80, 25);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(80, 155);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(318, 27);
            tbxSenha.TabIndex = 2;
            tbxSenha.UseSystemPasswordChar = true;
            tbxSenha.TextChanged += tbxSenha_TextChanged;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(80, 69);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(318, 27);
            tbxUsuario.TabIndex = 3;
            tbxUsuario.TextChanged += tbxUsuario_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(80, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 57);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(242, 206);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(156, 57);
            btnCadastro.TabIndex = 5;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(480, 301);
            Controls.Add(btnCadastro);
            Controls.Add(btnLogin);
            Controls.Add(tbxUsuario);
            Controls.Add(tbxSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox tbxSenha;
        private TextBox tbxUsuario;
        private Button btnLogin;
        private Button btnCadastro;
    }
}
