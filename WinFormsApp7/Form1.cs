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
            produtos.Add(new Produtos("Glitter", 10.00m));
            produtos.Add(new Produtos("CupCake", 20.00m));
            produtos.Add(new Produtos("Pirulito", 30.00m));
            produtos.Add(new Produtos("Bolo", 40.00m));
            produtos.Add(new Produtos("Biscoito", 50.00m));
            produtos.Add(new Produtos("Chocolate", 60.00m));
            produtos.Add(new Produtos("Bala", 70.00m));

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

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }
            var produto = (Produtos)lblProdutos.SelectedItem;
            carrinhos.Add(produto);
            totalCarrinho += produto.Preco;

            ListarCarrinho();
            TotalPagar();
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
            carrinhos.Remove(produto);
            totalCarrinho -= produto.Preco;
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
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }
    }
}
