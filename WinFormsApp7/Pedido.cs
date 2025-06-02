using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Pedido
    {
        public List<Produtos> produtos;
        private string cliente { get; set; }
        string metodo_pag;
        string viagem;
        string status;
        string data;
        
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Pedido(string cliente, string metodo_pag, string viagem)
        {
            this.produtos = produtos;
            this.cliente = cliente;
            this.metodo_pag = metodo_pag;
            this.viagem = viagem;
        }

        public override string ToString()
        {
            return $"Nome do Cliente: {Cliente} Produtos: {string.Join("\n, ", produtos)}";
        }
    }
}
    

