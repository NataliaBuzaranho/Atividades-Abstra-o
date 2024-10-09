namespace Ex___03
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Estoque { get; set; }
        


        public Produto(int codigo, string nome, int preco, int estoque, int valorestoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void valorEstoque()
        {
            Console.WriteLine($"O produto de nome " + Nome + " tem " + Estoque + " itens");
        }
    }
}
