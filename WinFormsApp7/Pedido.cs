using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Pedido
    {
        public static List<Produtos> produtos;
        public string cliente { get; set; }
        public string metodo_pag {  get; set; }
        public bool viagem { get; set; }
        public Status status { get; set; }
        public DateTime dataHora { get; set; }
   
        public Pedido(string cliente, string metodo_pag, string viagem, List<Produtos> produtos,Status status)
        {
            Pedido.produtos = produtos; 
            cliente = cliente;
            metodo_pag = metodo_pag;
            viagem = viagem;
            this.status = status;
            dataHora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Nome do Cliente: {cliente} Produtos: {string.Join("\n, ", produtos)}";
        }
    }
}
    

