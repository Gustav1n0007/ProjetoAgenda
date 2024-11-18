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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, editarToolStripMenuItem1 });
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
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // novaCategoriaToolStripMenuItem
            // 
            novaCategoriaToolStripMenuItem.Name = "novaCategoriaToolStripMenuItem";
            novaCategoriaToolStripMenuItem.Size = new Size(180, 22);
            novaCategoriaToolStripMenuItem.Text = "Nova categoria";
            novaCategoriaToolStripMenuItem.Click += novaCategoriaToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Menu agenda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}