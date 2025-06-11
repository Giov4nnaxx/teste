using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Pedido
    {
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();
        public string Cliente { get; set; }
        public string Metodo_pag { get; set; }
        public string Viagem { get; set; }
        public Status status { get; set; }
        public DateTime DataHora { get; set; }

        public Pedido(string cliente, string metodo_pag, string viagem, List<Produtos> produtos, Status status)
        {
            Produtos = produtos;
            Cliente = cliente;
            Metodo_pag = metodo_pag;
            Viagem = viagem;
            this.status = status;
            DataHora = DateTime.Now;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Pedido: {Cliente}--");
            if (this.status==Status.PREPARANDO)
            {
                foreach(var produto in Produtos)
                {
                    if (produto.isChapa)
                    {
                        sb.Append($" {produto.Quantidade}x - {produto.Descricao}");
                    }
                }
            }
            else
            {
                foreach(var produto in Produtos)
                    sb.Append($" {produto.Quantidade}x - {produto.Descricao}");
            }
            return sb.ToString();
            //string produtosTexto = string.Join(", ", Produtos.Select(p => $"x{p.Quantidade} {p.Descricao}"));
            //return $"{Cliente} - {produtosTexto}";
        }
    }
}
