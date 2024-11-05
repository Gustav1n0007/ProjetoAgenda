namespace ProjetoAgenda.Controller
{
    partial class frmCategoria
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
            components = new System.ComponentModel.Container();
            txtCategoria = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            listaCategorias = new ListBox();
            tmrAtualiza = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 49);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(365, 100);
            txtCategoria.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(12, 168);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 57);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(205, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 57);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 29);
            label1.TabIndex = 3;
            label1.Text = "Nome da categoria";
            // 
            // listaCategorias
            // 
            listaCategorias.FormattingEnabled = true;
            listaCategorias.ItemHeight = 15;
            listaCategorias.Location = new Point(423, 12);
            listaCategorias.Name = "listaCategorias";
            listaCategorias.Size = new Size(140, 214);
            listaCategorias.TabIndex = 4;
            // 
            // tmrAtualiza
            // 
            tmrAtualiza.Tick += tmrAtualiza_Tick;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 237);
            Controls.Add(listaCategorias);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCategoria);
            Name = "frmCategoria";
            Text = "frmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private ListBox listaCategorias;
        private System.Windows.Forms.Timer tmrAtualiza;
    }
}