using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    internal partial class Balcao : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> PedidosPendentes { get; set; }
        public Balcao()
        {
            InitializeComponent();
            PedidosPendentes = new List<string>();
        }

        public void AdicionarPedido(string pedido)
        {
            if (PedidosPendentes == null)
                PedidosPendentes = new List<string>();

            PedidosPendentes.Add(pedido);

            listBalcao.Items.Add(pedido);
        }

        private void listBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.FlatAppearance.BorderSize = 1;

            listBalcao.Items.Clear();
            if (PedidosPendentes != null)
            {
                foreach (var pedido in PedidosPendentes)
                {
                    listBalcao.Items.Add(pedido);
                }
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
       
        }
    }
}
