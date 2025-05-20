using Microsoft.VisualBasic;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {

        List<Produtos> produtos = new List<Produtos>();

        List<Produtos> carrinhos = new List<Produtos>();

        decimal totalCarrinho = 0;


        public Form1()
        {
            InitializeComponent();

            AdicionarProduto();

            ListarProdutos();
        }

        private void AdicionarProduto()
        {
            produtos.Add(new Produtos("P�o de Queijo", 3.50m));
            produtos.Add(new Produtos("Coxinha", 5.00m));
            produtos.Add(new Produtos("Pastel de Carne", 6.00m));
            produtos.Add(new Produtos("Pastel de Queijo", 5.50m));
            produtos.Add(new Produtos("Suco Natural (300ml)", 4.00m));
            produtos.Add(new Produtos("Refrigerante Lata", 4.50m));
            produtos.Add(new Produtos("Hamb�rguer Simples", 8.00m));
            produtos.Add(new Produtos("Hamb�rguer com Queijo", 9.00m));
            produtos.Add(new Produtos("X-Tudo", 12.00m));
            produtos.Add(new Produtos("�gua Mineral", 2.50m));
        }


        private void ListarProdutos()
        {
            lblProdutos.Items.Clear();
            foreach (var produto in produtos)
            {
                lblProdutos.Items.Add(produto);
            }
        }

        private void ListarCarrinho()
        {
            lblCarrinho.Items.Clear();
            foreach (var carrinho in carrinhos)
            {
                lblCarrinho.Items.Add(carrinho);
            }
        }
        private void lblProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblProdutos.SelectedItem != null)
            {
                numericQuant.Value = 1;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutos.SelectedItem != null && numericQuant.Value > 0)
            {
                int quant = (int)numericQuant.Value;
                Produtos produtoSelecionado = (Produtos)lblProdutos.SelectedItem;

                var itemExistente = carrinhos.FirstOrDefault(p => p.Descricao == produtoSelecionado.Descricao);

                if (itemExistente != null)
                {
                    itemExistente.Quantidade += quant;
                }
                else
                {
                    Produtos novoProduto = new Produtos(produtoSelecionado.Descricao, produtoSelecionado.Preco, quant);
                    carrinhos.Add(novoProduto);
                }

                totalCarrinho += produtoSelecionado.Preco * quant;

                ListarCarrinho();
                TotalPagar();

                lblProdutos.SelectedIndex = -1;
                numericQuant.Value = 1;
            }
            else if (numericQuant.Value <= 0)
            {
                MessageBox.Show("Indique uma quantidade v�lida!");
                numericQuant.Value = 1;
            }
            else
            {
                MessageBox.Show("Selecione um produto");
            }
        }

        private void TotalPagar()
        {
            total.Text = $"Total a pagar:R$ {totalCarrinho:F2}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblCarrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            var produto = (Produtos)lblCarrinho.SelectedItem;


            totalCarrinho -= produto.Preco * produto.Quantidade;
            produto.Quantidade = 0;
            carrinhos.Remove(produto);


            ListarCarrinho();
            TotalPagar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }

            var resultado = MessageBox.Show($"Total a pagar: R$ {totalCarrinho:F2}", "Finalizar compra", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Compra finalizada com sucesso");
                carrinhos.Clear();
                totalCarrinho = 0;
                ListarCarrinho();
                TotalPagar();
                listNomes.Items.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void lblCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Cart�o")
            {
                MessageBox.Show("Pagamento em Cart�o");

            }
            else if (comboBox1.SelectedItem == "Pix")
            {
                MessageBox.Show("Pagamento no Pix");
            }
            else if (comboBox1.SelectedItem == "Dinheiro")
            {
                var dinheiro = Interaction.InputBox($"O total � {totalCarrinho} Digite o valor ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                listNomes.Items.Add(txtNome.Text);
                txtNome.Clear();
            }
        }
    }
}
