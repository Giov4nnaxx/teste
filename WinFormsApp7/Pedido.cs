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
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"Nome do Cliente: {Cliente} Data e Horário: {Data}";
        }
    }
    internal static class Pedidos
    {
        public static Pedido SalvarPedido(string cliente, string produto, DateTime data, int quantidade = 1)
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
