using System.Collections.Generic;
using System.Linq;

public class Estoque
{
    private List<Produto> _produtos = new List<Produto>();

    // Adiciona um novo produto à lista de produtos do estoque
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    // Remove um produto da lista de produtos do estoque com base no ID do produto fornecido
    public void RemoverProduto(int produtoId)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == produtoId);
        if (produto != null)
        {
            _produtos.Remove(produto);
        }
    }

    // Atualiza a quantidade em estoque de um produto com base no ID do produto fornecido
    protected void AtualizarQuantidadeEmEstoque(int produtoId, int novaQuantidade)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == produtoId);
        if (produto != null)
        {
            produto.QuantidadeEmEstoque = novaQuantidade;
        }
    }

    // Busca um produto na lista de produtos do estoque com base no ID do produto fornecido e retorna o produto encontrado
    internal Produto BuscarProdutoPorId(int produtoId)
    {
        return _produtos.FirstOrDefault(p => p.Id == produtoId);
    }
}
