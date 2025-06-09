namespace WinFormsApp7
{

    public class Produtos
    {
        public string Descricao { get; set; }
        public bool IsChapa { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string descricao, decimal preco, bool isChapa)
        {
            Descricao = descricao;
            Preco = preco;
            Quantidade = 1;
            this.IsChapa = isChapa;
        }

        public override string ToString()
        {
            return $"{Descricao} - R$ {(Preco*Quantidade):F2}";
        }
    }
}