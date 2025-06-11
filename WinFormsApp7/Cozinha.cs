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

            foreach (var pedido in PedidosFinalizados.pedidosFinalizados)
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
