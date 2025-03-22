namespace Mercado.Cadastro
{
    partial class EditarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProduto));
            dgvProdutos = new DataGridView();
            txtId = new TextBox();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtValor = new TextBox();
            btnSelecionar = new Button();
            btnSalvarAlteracoe = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.Anchor = AnchorStyles.None;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(157, 161);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(452, 261);
            dgvProdutos.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(157, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.Location = new Point(279, 87);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.Location = new Point(402, 87);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 25);
            txtNome.TabIndex = 3;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.None;
            txtValor.Location = new Point(522, 89);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 25);
            txtValor.TabIndex = 4;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Anchor = AnchorStyles.None;
            btnSelecionar.Location = new Point(157, 116);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(100, 26);
            btnSelecionar.TabIndex = 5;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click_1;
            // 
            // btnSalvarAlteracoe
            // 
            btnSalvarAlteracoe.Anchor = AnchorStyles.None;
            btnSalvarAlteracoe.Location = new Point(314, 439);
            btnSalvarAlteracoe.Name = "btnSalvarAlteracoe";
            btnSalvarAlteracoe.Size = new Size(100, 30);
            btnSalvarAlteracoe.TabIndex = 6;
            btnSalvarAlteracoe.Text = "Salvar";
            btnSalvarAlteracoe.UseVisualStyleBackColor = true;
            btnSalvarAlteracoe.Click += btnSalvarAlteracoe_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.None;
            btnExcluir.Location = new Point(199, 439);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 30);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Location = new Point(420, 439);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 30);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(157, 69);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(279, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(402, 71);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(522, 71);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Valor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvProdutos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnSelecionar);
            panel1.Controls.Add(btnSalvarAlteracoe);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 13;
            // 
            // EditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__upload__3642;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "EditarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "z";
            Load += EditarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
        private TextBox txtId;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtValor;
        private Button btnSelecionar;
        private Button btnSalvarAlteracoe;
        private Button btnExcluir;
        private Button btnVoltar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}