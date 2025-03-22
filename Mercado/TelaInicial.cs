namespace Mercado
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu(); // Cria uma instância do Form Menu
            menuForm.Show(); // Exibe o Form Menu
            this.Hide(); // Esconde a TelaInicial
        }

        private void TelaInicial_Resize(object sender, EventArgs e)
        {
            // Obtém o tamanho da tela
            Rectangle screen = Screen.FromControl(this).Bounds;

            // Calcula a posição para centralizar
            int posX = (screen.Width - this.Width) / 2;
            int posY = (screen.Height - this.Height) / 2;

            // Define a posição para manter centralizado
            this.Location = new Point(posX, posY);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
