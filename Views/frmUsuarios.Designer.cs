namespace ProjetoAgenda.Views
{
    partial class frmUsuarios
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
            dgvUsers = new DataGridView();
            bntExcluir = new Button();
            txtNovaSenha = new TextBox();
            btnAlterarSenha = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(29, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(303, 311);
            dgvUsers.TabIndex = 0;
            // 
            // bntExcluir
            // 
            bntExcluir.Location = new Point(29, 342);
            bntExcluir.Name = "bntExcluir";
            bntExcluir.Size = new Size(159, 59);
            bntExcluir.TabIndex = 1;
            bntExcluir.Text = "Excluir";
            bntExcluir.UseVisualStyleBackColor = true;
            bntExcluir.Click += bntExcluir_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(439, 84);
            txtNovaSenha.Multiline = true;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(329, 52);
            txtNovaSenha.TabIndex = 2;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(439, 155);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(329, 59);
            btnAlterarSenha.TabIndex = 3;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlterarSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(bntExcluir);
            Controls.Add(dgvUsers);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button bntExcluir;
        private TextBox txtNovaSenha;
        private Button btnAlterarSenha;
    }
}