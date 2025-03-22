namespace Mercado
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnCadastrar = new Button();
            btnEditarProduto = new Button();
            btnRegistrarVenda = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.Location = new Point(208, 80);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(351, 112);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar\r\nProduto\r\n";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Anchor = AnchorStyles.None;
            btnEditarProduto.Location = new Point(208, 224);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(351, 112);
            btnEditarProduto.TabIndex = 2;
            btnEditarProduto.Text = "Editar \r\nProduto";
            btnEditarProduto.UseVisualStyleBackColor = true;
            btnEditarProduto.Click += btnModificar_Click;
            // 
            // btnRegistrarVenda
            // 
            btnRegistrarVenda.Anchor = AnchorStyles.None;
            btnRegistrarVenda.Location = new Point(208, 366);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(351, 112);
            btnRegistrarVenda.TabIndex = 3;
            btnRegistrarVenda.Text = "Vendas";
            btnRegistrarVenda.UseVisualStyleBackColor = true;
            btnRegistrarVenda.Click += btnRegistrarVenda_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnEditarProduto);
            panel1.Controls.Add(btnRegistrarVenda);
            panel1.Controls.Add(btnCadastrar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 4;
            // 
            // Menu
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
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private Button btnEditarProduto;
        private Button btnRegistrarVenda;
        private Panel panel1;
    }
}