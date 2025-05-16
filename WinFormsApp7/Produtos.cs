namespace WinFormsApp7
{
    internal class Produtos
    {
        private string descricao;
        private decimal preco;
        private int quantidade = 0;
        public string Descricao
        {
            get { return descricao; }
        }
        public double Preco
        {
            get { return preco; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }
        public object listBox2 { get; internal set; }

        public Produtos(string descricao,decimal preco)
        {

            this.descricao = descricao;
            this.preco = preco;
            this.quantidade = 0;

        }
        public override string ToString()
        {
            if (quantidade > 0)
                return $" {quantidade}x {descricao} - R$ {preco:F2}";
            else return $"  {descricao} - R$ {preco:F2}";
        }
    }
}