namespace WinFormsApp7
{

    public class Produtos
    {
        public string Descricao { get; set; }
        public bool IsChapa { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string descricao, decimal preco, bool isChapa = false)
        {
            Descricao = descricao;
            Preco = preco;
            Quantidade = 0;
            this.IsChapa = isChapa;
        }

        public override string ToString()
        {
            return $" {Descricao} - R$ {(Preco * Quantidade):F2}";
        }
    }
}