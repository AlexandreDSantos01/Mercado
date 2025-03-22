using Mercado.Cadastro;
using Mercado.Classes;
using Mercado.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Menu : Form
    {
        private List<Produto> listaProdutos = new List<Produto>();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o Menu em vez de fechar
            CadastroProduto formCadastroProduto = new CadastroProduto(listaProdutos);
            formCadastroProduto.ShowDialog();
            this.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarProduto formEditarProduto = new EditarProduto(listaProdutos);
            formEditarProduto.ShowDialog();
            this.Show();


        }
      

        private void btnRegistrarVenda_Click_1(object sender, EventArgs e)
        {
            RegistrarVenda registrarVenda = new RegistrarVenda(listaProdutos);
            registrarVenda.ShowDialog();
        }
    }
}
