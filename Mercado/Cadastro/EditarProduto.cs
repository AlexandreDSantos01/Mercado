using Mercado.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mercado.Cadastro
{
    public partial class EditarProduto : Form
    {
        private List<Produto> listaProdutos;
        private Produto produtoSelecionado; // Produto encontrado pelo ID

        public EditarProduto(List<Produto> produtos)
        {
            InitializeComponent();
            listaProdutos = produtos;
            dgvProdutos.ReadOnly = true; // Impede edição direta no grid
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;

            // Ajuste automático das colunas para preencher todo o espaço disponível
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProdutos.Columns["Valor"].DefaultCellStyle.Format = "C2"; // Formata como moeda
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela
        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            string idDigitado = txtId.Text.Trim();

            if (string.IsNullOrEmpty(idDigitado))
            {
                MessageBox.Show("Digite um ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            produtoSelecionado = listaProdutos.FirstOrDefault(p => p.Id == idDigitado);

            if (produtoSelecionado != null)
            {
                txtCodigo.Text = produtoSelecionado.Codigo;
                txtNome.Text = produtoSelecionado.Nome;
                txtValor.Text = produtoSelecionado.Valor.ToString("F2");
            }
            else
            {
                MessageBox.Show("Produto não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarAlteracoe_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado != null)
            {
                // Confirmação antes de salvar
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja salvar as alterações?",
                                                        "Confirmação",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                    return; // Cancela a operação

                produtoSelecionado.Nome = txtNome.Text;

                if (decimal.TryParse(txtValor.Text, out decimal novoValor))
                {
                    produtoSelecionado.Valor = novoValor;
                }
                else
                {
                    MessageBox.Show("O valor informado não é válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AtualizarGrid();
                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (produtoSelecionado != null)
            {
                // Confirmação antes de excluir
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este produto?",
                                                        "Confirmação",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                if (resposta == DialogResult.No)
                    return; // Cancela a operação

                listaProdutos.Remove(produtoSelecionado);
                produtoSelecionado = null;
                txtId.Clear();
                txtCodigo.Clear();
                txtNome.Clear();
                txtValor.Clear();
                AtualizarGrid();
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600); // Define o tamanho padrão
            this.MinimumSize = new Size(600, 400); // Define o tamanho mínimo
            this.MaximumSize = new Size(1024, 768); // Define o tamanho máximo

            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres inválidos
            }
        }
    }
}
