namespace WinFormsApp7
{
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            foreach (var pedido in PedidosFinalizados.pedidosFinalizados)
            {
                if (pedido.status == Status.PRONTO || pedido.status == Status.PREPARANDO)
                    listAndamento.Items.Add(pedido.Cliente);
                else if (pedido.status == Status.ENTREGUE)
                    listPronto.Items.Add(pedido.Cliente);
            }
        }

        private void listPronto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
