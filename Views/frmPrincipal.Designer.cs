namespace ProjetoAgenda.Views
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            novaCategoriaToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            lblBoasVindas = new Label();
            groupBox1 = new GroupBox();
            lblUser = new Label();
            lblNome = new Label();
            lblUsuario = new Label();
            lblNomeDoUsuario = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, editarToolStripMenuItem1, agendaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1 });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(61, 20);
            cadastrosToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(93, 22);
            cadastrarToolStripMenuItem1.Text = "Sair";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, usuariosToolStripMenuItem });
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(49, 20);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaCategoriaToolStripMenuItem });
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // novaCategoriaToolStripMenuItem
            // 
            novaCategoriaToolStripMenuItem.Name = "novaCategoriaToolStripMenuItem";
            novaCategoriaToolStripMenuItem.Size = new Size(154, 22);
            novaCategoriaToolStripMenuItem.Text = "Nova categoria";
            novaCategoriaToolStripMenuItem.Click += novaCategoriaToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(130, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(60, 20);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Location = new Point(186, 9);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(0, 15);
            lblBoasVindas.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(lblNomeDoUsuario);
            groupBox1.Location = new Point(432, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 260);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Usuario";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(35, 165);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 21);
            lblUser.TabIndex = 3;
            lblUser.Text = "label1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(35, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 21);
            lblNome.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(30, 120);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(103, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "lblUsuario";
            // 
            // lblNomeDoUsuario
            // 
            lblNomeDoUsuario.AutoSize = true;
            lblNomeDoUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDoUsuario.Location = new Point(30, 39);
            lblNomeDoUsuario.Name = "lblNomeDoUsuario";
            lblNomeDoUsuario.Size = new Size(66, 25);
            lblNomeDoUsuario.TabIndex = 0;
            lblNomeDoUsuario.Text = "Nome";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblBoasVindas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Menu agenda";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem novaCategoriaToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private Label lblBoasVindas;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private GroupBox groupBox1;
        private Label lblUser;
        private Label lblNome;
        private Label lblUsuario;
        private Label lblNomeDoUsuario;
    }
}