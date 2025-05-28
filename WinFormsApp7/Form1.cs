using Microsoft.VisualBasic;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {

        private List<string> pedidosPendentes = new List<string>();

        List<Produtos> produtos = new List<Produtos>();

        List<Produtos> carrinhos = new List<Produtos>();

        decimal totalCarrinho = 0;

        private Balcao balcaoForm;

        public Form1()
        {
            InitializeComponent();

            AdicionarProduto();

            ListarProdutos();
        }

        private void AdicionarProduto()
        {
            produtos.Add(new Produtos("Pão de Queijo", 3.50m));
            produtos.Add(new Produtos("Coxinha", 5.00m));
            produtos.Add(new Produtos("Pastel de Carne", 6.00m));
            produtos.Add(new Produtos("Pastel de Queijo", 5.50m));
            produtos.Add(new Produtos("Suco Natural (300ml)", 4.00m));
            produtos.Add(new Produtos("Refrigerante Lata", 4.50m));
            produtos.Add(new Produtos("Hambúrguer Simples", 8.00m));
            produtos.Add(new Produtos("Hambúrguer com Queijo", 9.00m));
            produtos.Add(new Produtos("X-Tudo", 12.00m));
            produtos.Add(new Produtos("Água Mineral", 2.50m));
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
                lblCarrinho.Items.Add($"x{carrinho.Quantidade} {carrinho.Descricao} - R$ {carrinho.Preco * carrinho.Quantidade:F2}");
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

                string nome = listNomes.Text;
                string horario = DateTime.Now.ToString("HH:mm:ss");

                string itemPedido = $"Nome do Cliente : {nome}  Horário :{horario}";
                foreach (var produto in carrinhos)
                {
                    itemPedido += $"x {produto.Quantidade} {produto.Descricao} - R$ {produto.Preco:F2}";
                }
                pedidosPendentes.Add(itemPedido);

                if (balcaoForm != null && !balcaoForm.IsDisposed)
                {
                    balcaoForm.AdicionarPedido(itemPedido);
                }

                lblProdutos.SelectedIndex = -1;
                numericQuant.Value = 1;
            }
            else if (numericQuant.Value <= 0)
            {
                MessageBox.Show("Indique uma quantidade válida!");
                numericQuant.Value = 1;
            }
            else
            {
                MessageBox.Show("Selecione um produto");
            }
        }
        private void Extrato()
        {
            string nomeDoCliente = listNomes.SelectedItem?.ToString() ?? "(Sem cliente)";
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
            if (comboBox1.SelectedItem == "Cartão")
            {
                MessageBox.Show("Pagamento em Cartão");

            }
            else if (comboBox1.SelectedItem == "Pix")
            {
                MessageBox.Show("Pagamento no Pix");
            }
            else if (comboBox1.SelectedItem == "Dinheiro")
            {
                string input = Interaction.InputBox($"O total é R$ {totalCarrinho:F2}. Digite o valor:");
                if (decimal.TryParse(input, out decimal dinheiro))
                {
                    decimal troco = dinheiro - totalCarrinho;
                    if (dinheiro < totalCarrinho)
                    {
                        MessageBox.Show($"Está faltando {troco:F2}");
                        Pagamento();
                    }
                    else
                    {
                        MessageBox.Show($"Troco: R$ {troco:F2}");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido. Tente novamente.");
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
            var produto = (Produtos)lblCarrinho.SelectedItem;

            int quantidadeRemover = (int)numericQuant.Value;

            if (quantidadeRemover < 0)
            {
                MessageBox.Show("Indique uma quantidade válida!");
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
            Extrato();
            numericQuant.Value = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carrinhos.Count == 0)
            {
                MessageBox.Show("Carrinho vazio");
                return;
            }
            else if (listNomes.Items.Count == 0)
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

            if (resultado == DialogResult.Yes)
            {
                Extrato();
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
            Pagamento();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                listNomes.Items.Add(txtNome.Text);
                listNomes.SelectedIndex = listNomes.Items.Count - 1;
                txtNome.Clear();
            }
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
            btnNomes.FlatStyle = FlatStyle.Flat;
            btnNomes.FlatAppearance.BorderSize = 1;
            btnBalcao.FlatStyle = FlatStyle.Flat;
            btnBalcao.FlatAppearance.BorderSize = 1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (balcaoForm == null || balcaoForm.IsDisposed)
            {
                balcaoForm = new Balcao();
                foreach (var pedido in pedidosPendentes)
                {
                    balcaoForm.AdicionarPedido(pedido);
                }

                balcaoForm.Show();
            }
            else
            {
                balcaoForm.BringToFront();
            }
            
        }
    }
}
