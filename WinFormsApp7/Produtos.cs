namespace WinFormsApp7
{

    public class Produtos
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string descricao, decimal preco, int quantidade = 1)
        {
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;

        }

        public override string ToString()
        {
            return $"x{Quantidade} {Descricao} - R$ {(Preco * Quantidade):F2}";
        }
    }
}