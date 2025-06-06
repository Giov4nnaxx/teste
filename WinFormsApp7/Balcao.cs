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
        public Balcao()
        {
            InitializeComponent();
        }

        private void listBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.FlatAppearance.BorderSize = 1;

            listBalcao.Items.Clear();

            foreach (var pedido in PedidosFinalizados.pedidosFinalizados)
            {
                if (pedido.status == Status.PRONTO)
                    listBalcao.Items.Add(pedido.ToString());
                else
                {
                    listEntregues.Items.Add(pedido.ToString());
                }
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
