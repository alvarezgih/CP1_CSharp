public class Produto
{
    internal int QuantidadeEmEstoque;

    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    // Construtor
    public Produto(int id, string nome, decimal preco, int estoque)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    // Método sobrescrito para representação textual do produto
    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Preço: {Preco:C}, Estoque: {Estoque}";
    }
}