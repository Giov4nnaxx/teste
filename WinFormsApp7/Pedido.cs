using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Pedido
    {
        public static List<Produtos> produtos = new List<Produtos>();
        public string Cliente { get; set; }
        public string Metodo_pag { get; set; }
        public string Viagem { get; set; }
        public Status status { get; set; }
        public DateTime DataHora { get; set; }


        //public Pedido(string cliente, string metodo_pag, string viagem, List<Produtos> produtos, Status status)
        //{
        //    Pedido.produtos = produtos;
        //    Cliente = cliente;
        //    Metodo_pag = metodo_pag;
        //    Viagem = viagem;
        //    this.status = status;
        //    DataHora = DateTime.Now;
        //}

        public override string ToString()
        {
            string produtosDescricao = string.Join(", ", produtos.Select(p => p.Descricao));
            return $"{Cliente} - {produtosDescricao}";
        }
    }
}
    

