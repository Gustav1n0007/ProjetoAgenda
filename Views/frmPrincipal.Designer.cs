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
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarToolStripMenuItem3 = new ToolStripMenuItem();
            cadastrarToolStripMenuItem2 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, cadastrosToolStripMenuItem, editarToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, arquivoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(61, 20);
            menuToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(180, 22);
            arquivoToolStripMenuItem.Text = "Salvar";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, editarToolStripMenuItem, cadastrarToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(12, 20);
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(67, 22);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(67, 22);
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(67, 22);
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem3, cadastrarToolStripMenuItem2 });
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(49, 20);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // cadastrarToolStripMenuItem3
            // 
            cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
            cadastrarToolStripMenuItem3.Size = new Size(124, 22);
            cadastrarToolStripMenuItem3.Text = "Cadastrar";
            // 
            // cadastrarToolStripMenuItem2
            // 
            cadastrarToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem });
            cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            cadastrarToolStripMenuItem2.Size = new Size(124, 22);
            cadastrarToolStripMenuItem2.Text = "Cadastrar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem cadastrarToolStripMenuItem2;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem3;
    }
}