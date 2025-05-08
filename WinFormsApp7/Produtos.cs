using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Produtos
    {
        public string Nome { get; set; }    
        public decimal Preco { get; set; }

        public Produtos(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome} - {Preco:C}";
        }

    }
}
