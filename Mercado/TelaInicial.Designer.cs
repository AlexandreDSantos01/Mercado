namespace Mercado
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            btnEntrar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.Location = new Point(323, 304);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(132, 53);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entra";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += label1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(228, 149);
            label1.Name = "label1";
            label1.Size = new Size(309, 73);
            label1.TabIndex = 1;
            label1.Text = "Bem Vindo";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEntrar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 2;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__upload__3642;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mercado";
            Load += TelaInicial_Load;
            Resize += TelaInicial_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private Panel panel1;
    }
}
