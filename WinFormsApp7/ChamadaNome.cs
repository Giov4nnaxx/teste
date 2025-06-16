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
    public partial class ChamadaNome : Form
    {
        public ChamadaNome()
        {
            InitializeComponent();
        }

        private void ChamadaNome_Load(object sender, EventArgs e)
        {
            foreach(var produto in PedidosFinalizados.pedidosFinalizados)
                lblNome.Text = produto.Cliente;
        }
    }
}
