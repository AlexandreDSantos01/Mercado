namespace Mercado.Vendas
{
    partial class RegistrarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVenda));
            label1 = new Label();
            txtCodigoProduto = new TextBox();
            btnAdicionarProduto = new Button();
            dgvListaVenda = new DataGridView();
            label2 = new Label();
            txtTotalVenda = new TextBox();
            btnRemoverProduto = new Button();
            btnFinalizarVenda = new Button();
            btnVoltar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListaVenda).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(221, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Código do Produto";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Anchor = AnchorStyles.None;
            txtCodigoProduto.Location = new Point(210, 44);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(133, 23);
            txtCodigoProduto.TabIndex = 1;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Anchor = AnchorStyles.None;
            btnAdicionarProduto.Location = new Point(210, 73);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(133, 42);
            btnAdicionarProduto.TabIndex = 2;
            btnAdicionarProduto.Text = "Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // dgvListaVenda
            // 
            dgvListaVenda.Anchor = AnchorStyles.None;
            dgvListaVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaVenda.Location = new Point(126, 121);
            dgvListaVenda.Name = "dgvListaVenda";
            dgvListaVenda.Size = new Size(522, 356);
            dgvListaVenda.TabIndex = 3;
            dgvListaVenda.CellContentClick += dgvListaVenda_CellContentClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(458, 26);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Total da Venda";
            // 
            // txtTotalVenda
            // 
            txtTotalVenda.Anchor = AnchorStyles.None;
            txtTotalVenda.Location = new Point(432, 44);
            txtTotalVenda.Name = "txtTotalVenda";
            txtTotalVenda.Size = new Size(133, 23);
            txtTotalVenda.TabIndex = 5;
            // 
            // btnRemoverProduto
            // 
            btnRemoverProduto.Anchor = AnchorStyles.None;
            btnRemoverProduto.Location = new Point(432, 73);
            btnRemoverProduto.Name = "btnRemoverProduto";
            btnRemoverProduto.Size = new Size(133, 42);
            btnRemoverProduto.TabIndex = 6;
            btnRemoverProduto.Text = "Remover\r\nProduto\r\n";
            btnRemoverProduto.UseVisualStyleBackColor = true;
            btnRemoverProduto.Click += btnRemoverProduto_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Anchor = AnchorStyles.None;
            btnFinalizarVenda.Location = new Point(126, 483);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(133, 42);
            btnFinalizarVenda.TabIndex = 7;
            btnFinalizarVenda.Text = "Finalizar Venda";
            btnFinalizarVenda.UseVisualStyleBackColor = true;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Location = new Point(515, 483);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(133, 42);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(dgvListaVenda);
            panel1.Controls.Add(btnFinalizarVenda);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRemoverProduto);
            panel1.Controls.Add(txtCodigoProduto);
            panel1.Controls.Add(txtTotalVenda);
            panel1.Controls.Add(btnAdicionarProduto);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 9;
            // 
            // RegistrarVenda
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
            Name = "RegistrarVenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mercado";
            Load += RegistrarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaVenda).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCodigoProduto;
        private Button btnAdicionarProduto;
        private DataGridView dgvListaVenda;
        private Label label2;
        private TextBox txtTotalVenda;
        private Button btnRemoverProduto;
        private Button btnFinalizarVenda;
        private Button btnVoltar;
        private Panel panel1;
    }
}