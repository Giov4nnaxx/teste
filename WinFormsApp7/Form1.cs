using Microsoft.VisualBasic;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        List<Produtos> produtos = new List<Produtos>();

        List<Produtos> carrinhos = new List<Produtos>();

        decimal totalCarrinho = 0;

        private Balcao balcaoForm;
        private Cozinha cozinhaForm;

        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            ListarProdutos();
        }

        private void AdicionarProduto()
        {
            produtos.Add(new Produtos("P�o de Queijo", 3.50m, false));
            produtos.Add(new Produtos("Coxinha", 5.00m, false));
            produtos.Add(new Produtos("Pastel de Carne", 6.00m, true));
            produtos.Add(new Produtos("Pastel de Queijo", 5.50m, true));
            produtos.Add(new Produtos("Suco Natural (300ml)", 4.00m, true));
            produtos.Add(new Produtos("Refrigerante Lata", 4.50m, false));
            produtos.Add(new Produtos("Hamb�rguer Simples", 8.00m, true));
            produtos.Add(new Produtos("Hamb�rguer com Queijo", 9.00m, true));
            produtos.Add(new Produtos("X-Tudo", 12.00m, true));
            produtos.Add(new Produtos("�gua Mineral", 2.50m, false));
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
                    Produtos novoProduto = new Produtos(produtoSelecionado.Descricao, produtoSelecionado.Preco, produtoSelecionado.IsChapa)
                    {
                        Quantidade = quant
                    };
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
        private void Extrato()
        {
            string nomeDoCliente = txtNome.Text.ToString() ?? "(Sem cliente)";
            string formaDePagamento = comboBox1.SelectedItem?.ToString() ?? "(Sem pagamento)";
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio.", "Extrato da Compra");
                return;
            }

            string extrato = $"Nome do Cliente: {nomeDoCliente}\n\nForma de Pagamento: {formaDePagamento}\n\nProdutos:\n";
            foreach (var produto in carrinhos)
            {
                extrato += $"x {produto.Quantidade} {produto.Descricao} - R$ {produto.Preco:F2} \n";
                if (checkBox1.Checked)
                {
                    extrato = $"Para Viagem \n\nNome do Cliente: {nomeDoCliente}\n\nForma de Pagamento: {formaDePagamento}\n\nProdutos:\n ";
                    foreach (var produtoViagem in carrinhos)
                    {
                        extrato += $"x {produto.Quantidade} {produto.Descricao} - R$ {produto.Preco:F2} \n";
                    }
                }
            }
            extrato += $"Total: R$ {totalCarrinho:F2}\n\n{dataAtual}";
            MessageBox.Show(extrato, "Extrato da Compra");
        }
        private void Pagamento()
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
                string input = Interaction.InputBox($"O total � R$ {totalCarrinho:F2}. Digite o valor:");
                if (decimal.TryParse(input, out decimal dinheiro))
                {
                    decimal troco = dinheiro - totalCarrinho;
                    if (dinheiro < totalCarrinho)
                    {
                        MessageBox.Show($"Est� faltando {troco:F2}");
                        Pagamento();
                    }
                    else
                    {
                        MessageBox.Show($"Troco: R$ {troco:F2}");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inv�lido. Tente novamente.");
                    Pagamento();
                }
            }
        }

        private void TotalPagar()
        {
            total.Text = $"Total: R$ {totalCarrinho:F2}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblCarrinho.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            var produto = lblCarrinho.SelectedItem as Produtos;

            int quantidadeRemover = (int)numericQuant.Value;

            if (quantidadeRemover < 0)
            {
                MessageBox.Show("Indique uma quantidade v�lida!");
                return;
            }

            else if (quantidadeRemover >= produto.Quantidade)
            {
                totalCarrinho -= produto.Preco * produto.Quantidade;
                carrinhos.Remove(produto);
            }

            else if (quantidadeRemover < numericQuant.Value)
            {

            }
            else
            {
                produto.Quantidade -= quantidadeRemover;
                totalCarrinho -= produto.Preco * quantidadeRemover;
            }

            ListarCarrinho();
            TotalPagar();
            numericQuant.Value = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Sem Cliente Cadastrado");
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento");
                return;
            }

            var resultado = MessageBox.Show($"Total a pagar: R$ {totalCarrinho:F2}", "Finalizar compra", MessageBoxButtons.YesNo);
            var formaDePagamento = comboBox1.SelectedItem?.ToString() ?? "(Sem pagamento)";
            var viagem = checkBox1.Checked ? "Sim" : "N�o";

            if (resultado == DialogResult.Yes)
            {
                Extrato();
                bool pedidoChapa = carrinhos.Any(p => p.IsChapa);
                Status status = pedidoChapa ? Status.PREPARANDO : Status.PRONTO;

                var novoPedido = new Pedido(
                    txtNome.Text,
                    comboBox1.SelectedItem?.ToString() ?? "(Sem pagamento)",
                    checkBox1.Checked ? "Sim" : "N�o",
                    new List<Produtos>(carrinhos),
                    status
                );
                PedidosFinalizados.pedidosFinalizados.Add(novoPedido);

                balcaoForm?.AtualizarPedidos();

                carrinhos.Clear();
                totalCarrinho = 0;
                ListarCarrinho();
                TotalPagar();
                txtNome.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "";
                checkBox1.Checked = false;
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
            string cliente = txtNome.Text;

        }

        private void listNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pagamento();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.FlatAppearance.BorderSize = 1;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.FlatAppearance.BorderSize = 1;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.FlatAppearance.BorderSize = 1;
            btnBalcao.FlatStyle = FlatStyle.Flat;
            btnBalcao.FlatAppearance.BorderSize = 1;
            btnCozinha.FlatStyle = FlatStyle.Flat;
            btnCozinha.FlatAppearance.BorderSize = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            balcaoForm = new Balcao();
            balcaoForm.ShowDialog();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            cozinhaForm = new Cozinha();
            cozinhaForm.ShowDialog();
        }
    }
}

