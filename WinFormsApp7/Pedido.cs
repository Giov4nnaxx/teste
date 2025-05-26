using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Pedido
    {
        public string Cliente { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
        public int Hora { get; set; }
    }
    internal static class Pedidos
    {
        public static Pedido SalvarPedido(string cliente, string item, int hora, int quantidade = 1)
        {
            return new Pedido
            {
                Cliente = cliente,
                Quantidade = quantidade,
                Item = item,
                Hora = hora
            };
        }
    }
}
