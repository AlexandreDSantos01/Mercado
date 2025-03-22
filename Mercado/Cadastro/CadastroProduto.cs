using Mercado.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mercado.Cadastro
{
    public partial class CadastroProduto : Form
    {
        private static int idCounter = 1; // Controla o ID, incrementando
        private List<Produto> listaProdutos; // Referência à lista original

        // 🔹 Construtor que recebe a lista de produtos
        public CadastroProduto(List<Produto> produtos)
        {
            InitializeComponent();
            listaProdutos = produtos; // Atribui a lista passada
            ConfigurarGrid();
            AtualizarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvProdutos.ReadOnly = true; // Impede edição direta no grid
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleção de linha inteira
            dgvProdutos.MultiSelect = false; // Permite selecionar apenas um item por vez
        }

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            txtId.Text = idCounter++.ToString();
            Random rnd = new Random();
            txtCodigo.Text = rnd.Next(10000000, 99999999).ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduto.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out decimal valorProduto))
            {
                MessageBox.Show("O valor informado não é válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto novoProduto = new Produto
            {
                Id = txtId.Text,
                Codigo = txtCodigo.Text,
                Nome = txtProduto.Text,
                Valor = valorProduto
            };

            listaProdutos.Add(novoProduto); // Agora adiciona na lista compartilhada!
            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarGrid(); // Atualiza o DataGridView

            // Gera um novo ID e limpa os campos para o próximo cadastro
            btnGerarId_Click(sender, e);
            txtProduto.Clear();
            txtValor.Clear();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;

            // Ajusta automaticamente o tamanho das colunas
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvProdutos.Columns["Valor"] != null)
            {
                dgvProdutos.Columns["Valor"].DefaultCellStyle.Format = "C2"; // Formata como moeda
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres inválidos
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
