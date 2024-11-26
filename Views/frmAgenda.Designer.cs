namespace ProjetoAgenda.Views
{
    partial class frmAgenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContato = new TextBox();
            txtTelefone = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            dgvContatos = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 26);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Contato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 101);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 179);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(45, 59);
            txtContato.Multiline = true;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(262, 39);
            txtContato.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(45, 137);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(262, 39);
            txtTelefone.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(45, 273);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(119, 48);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(170, 273);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(137, 48);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(45, 343);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(119, 48);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(349, 59);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(576, 332);
            dgvContatos.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 10;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(comboBox1);
            Controls.Add(dgvContatos);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(txtContato);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgenda";
            Text = "frmAgenda";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private TextBox txtCategoria;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnAlterar;
        private DataGridView dgvContatos;
        private ComboBox comboBox1;
    }
}