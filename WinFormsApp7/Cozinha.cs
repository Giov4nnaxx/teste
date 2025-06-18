namespace WinFormsApp7
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            btnEntregarCozinha.FlatStyle = FlatStyle.Flat;
            btnEntregarCozinha.FlatAppearance.BorderSize = 1;

            foreach (Pedido pedido in PedidosFinalizados.pedidosFinalizados)
            {
                if (pedido.status == Status.PREPARANDO)
                    listCozinha.Items.Add(pedido);
            }
        }

        private void btnEntregarCozinha_Click(object sender, EventArgs e)
        {
            if (listCozinha.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Pedido!!");
                return;
            }
            var pedidoSelecionado = listCozinha.SelectedItem as Pedido;
            pedidoSelecionado.status = Status.PRONTO;

            listCozinha.Items.Remove(pedidoSelecionado);

        }
    }
}
