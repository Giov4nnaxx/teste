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
        public string Produto { get; set; }
        public string Data { get; set; }   


    }
    internal static class Pedidos
    {
        public static Pedido SalvarPedido(string cliente, string produto, string data, int quantidade = 1)
        {
            return new Pedido
            {
                Cliente = cliente,
                Quantidade = quantidade,
                Produto = produto,
                Data = data
            };
        }
    }
}
