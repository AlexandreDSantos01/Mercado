using Mercado.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mercado.Vendas
{
    public partial class RegistrarVenda : Form
    {
        private List<Produto> listaProdutos; // Lista de produtos cadastrados
        private List<Produto> listaVenda; // Produtos na venda atual
        private decimal totalVenda = 0;

        public RegistrarVenda(List<Produto> produtos)
        {
            InitializeComponent();
            listaProdutos = produtos;
            listaVenda = new List<Produto>();
            dgvListaVenda.ReadOnly = true; // Impede edição no DataGridView
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string codigoDigitado = txtCodigoProduto.Text.Trim();

            if (string.IsNullOrEmpty(codigoDigitado))
            {
                MessageBox.Show("Digite o código do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o produto pelo código
            Produto produtoSelecionado = listaProdutos.FirstOrDefault(p => p.Codigo == codigoDigitado);

            if (produtoSelecionado != null)
            {
                listaVenda.Add(produtoSelecionado);
                totalVenda += produtoSelecionado.Valor;

                AtualizarGrid();
                txtCodigoProduto.Clear();
            }
            else
            {
                MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgvListaVenda.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover este produto da venda?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Produto produtoSelecionado = (Produto)dgvListaVenda.SelectedRows[0].DataBoundItem;
                    listaVenda.Remove(produtoSelecionado);
                    totalVenda -= produtoSelecionado.Valor;

                    AtualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (listaVenda.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado à venda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente finalizar a venda?",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Exibir recibo
                string recibo = "Recibo de Venda\n\n";
                foreach (var produto in listaVenda)
                {
                    recibo += $"{produto.Nome} - {produto.Valor:C2}\n";
                }
                recibo += $"\nTotal: {totalVenda:C2}";

                MessageBox.Show(recibo, "Venda Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar a venda após finalização
                listaVenda.Clear();
                totalVenda = 0;
                AtualizarGrid();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja voltar? A venda atual será perdida!",
                                                     "Confirmação",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AtualizarGrid()
        {
            dgvListaVenda.DataSource = null;
            dgvListaVenda.DataSource = listaVenda;

            // Ajuste automático das colunas para preencher todo o espaço disponível
            dgvListaVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListaVenda.Columns["Valor"].DefaultCellStyle.Format = "C2"; // Formata como moeda
            dgvListaVenda.Columns["Id"].Visible = false;
            txtTotalVenda.Text = totalVenda.ToString("C2"); // Atualiza o total
        }

        private void dgvListaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RegistrarVenda_Load(object sender, EventArgs e)
        {
        }
    }
}
