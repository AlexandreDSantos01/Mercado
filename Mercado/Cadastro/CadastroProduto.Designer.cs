namespace Mercado.Cadastro
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProduto = new TextBox();
            txtValor = new TextBox();
            txtId = new TextBox();
            btnGerarId = new Button();
            btnSalvar = new Button();
            dgvProdutos = new DataGridView();
            btnVoltar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(47, 196);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.None;
            txtCodigo.Location = new Point(16, 214);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(111, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(47, 269);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Produto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(236, 269);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(241, 196);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 4;
            label4.Text = "Id";
            // 
            // txtProduto
            // 
            txtProduto.Anchor = AnchorStyles.None;
            txtProduto.Location = new Point(16, 287);
            txtProduto.MaxLength = 30;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(111, 23);
            txtProduto.TabIndex = 5;
            txtProduto.KeyPress += txtProduto_KeyPress;
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.None;
            txtValor.Location = new Point(197, 287);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(111, 23);
            txtValor.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(197, 214);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(111, 23);
            txtId.TabIndex = 7;
            // 
            // btnGerarId
            // 
            btnGerarId.Anchor = AnchorStyles.None;
            btnGerarId.Location = new Point(109, 125);
            btnGerarId.Name = "btnGerarId";
            btnGerarId.Size = new Size(111, 51);
            btnGerarId.TabIndex = 8;
            btnGerarId.Text = "Gerar ID";
            btnGerarId.UseVisualStyleBackColor = true;
            btnGerarId.Click += btnGerarId_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Location = new Point(16, 332);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 51);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.Anchor = AnchorStyles.None;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.GridColor = SystemColors.ActiveCaption;
            dgvProdutos.Location = new Point(314, 125);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(434, 302);
            dgvProdutos.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Location = new Point(197, 332);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 51);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dgvProdutos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 13;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__upload__3642;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnGerarId);
            Controls.Add(txtId);
            Controls.Add(txtValor);
            Controls.Add(txtProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProduto;
        private TextBox txtValor;
        private TextBox txtId;
        private Button btnGerarId;
        private Button btnSalvar;
        private DataGridView dgvProdutos;
        private Button btnVoltar;
        private Panel panel1;
    }
}