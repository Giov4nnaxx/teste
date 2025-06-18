namespace WinFormsApp7
{
    internal partial class Balcao : Form
    {
        List<Pedido> pedidos = new List<Pedido>();

        private ChamadaNome chamadaNomeForm;
        private Chamada chamadaForm;
        public Balcao()
        {
            InitializeComponent();
        }
        public void AtualizarPedidos()
        {
            listBalcao.Items.Clear();
            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
            {
                listBalcao.Items.Add(pedido);
            }
        }

        public void listBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBalcao.SelectedItem is Pedido pedido)
            {
                string detalhes = $"Cliente: {pedido.Cliente}\n" +
                                  $"Pagamento: {pedido.Metodo_pag}\n" +
                                  $"Viagem: {pedido.Viagem}\n" +
                                  $"Status: {pedido.status}\n\nProdutos:\n";

                foreach (Produtos prod in pedido.Produtos)
                {
                    detalhes += $"x{prod.Quantidade} {prod.Descricao} - R$ {prod.Preco:F2}\n";
                }
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            btnEntregarCozinha.FlatStyle = FlatStyle.Flat;
            btnEntregarCozinha.FlatAppearance.BorderSize = 1;

            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
            {
                if (pedido.status == Status.PRONTO)
                    listBalcao.Items.Add(pedido);
                else if (pedido.status == Status.ENTREGUE)
                    listEntregues.Items.Add(pedido);
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listEntregues.Items.Count == 5)
                listEntregues.Items.RemoveAt(4);

            if (listBalcao.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Pedido!!");
                return;
            }
            
            Pedido pedidoSelecionado = listBalcao.SelectedItem as Pedido;
            pedidoSelecionado.status = Status.ENTREGUE;

            int index = listBalcao.SelectedIndex;
            listBalcao.Items.RemoveAt(index);

            listEntregues.Items.Insert(0, pedidoSelecionado);

            chamadaNomeForm = new ChamadaNome();
            chamadaNomeForm.chamada(pedidoSelecionado.Cliente);
            chamadaNomeForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listEntregues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chamadaForm = new Chamada();
            chamadaForm.ShowDialog();
        }
    }
}
