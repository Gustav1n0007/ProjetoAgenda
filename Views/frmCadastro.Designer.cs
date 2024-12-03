namespace ProjetoAgenda
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtRepeteSenha = new TextBox();
            lblConfirm = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(35, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 18);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 47);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += tbxNome_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(35, 103);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += tbxUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(35, 82);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 18);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(35, 160);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(320, 23);
            txtTelefone.TabIndex = 6;
            txtTelefone.TextChanged += tbxTelefone_TextChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(35, 140);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 18);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.Location = new Point(35, 272);
            txtRepeteSenha.Margin = new Padding(3, 2, 3, 2);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.PasswordChar = '*';
            txtRepeteSenha.Size = new Size(320, 23);
            txtRepeteSenha.TabIndex = 8;
            txtRepeteSenha.TextChanged += tbxConfirm_TextChanged;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirm.Location = new Point(35, 251);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(162, 18);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirme a senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(35, 215);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(320, 23);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += tbxSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(35, 194);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 18);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(35, 322);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(147, 44);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(207, 322);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 44);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(420, 412);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtRepeteSenha);
            Controls.Add(lblConfirm);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCadastro";
            Text = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtRepeteSenha;
        private Label lblConfirm;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}