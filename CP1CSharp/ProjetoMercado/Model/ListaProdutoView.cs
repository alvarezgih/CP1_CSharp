using System;
using System.Collections.Generic;

// View para listar produtos disponíveis
public class ListaProdutosView
{
    // Método para mostrar os produtos na tela
    public void MostrarProdutos(IEnumerable<Produto> produtos)
    {
        Console.WriteLine("Lista de Produtos Disponíveis:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}, Estoque: {produto.Estoque}");
        }
    }
}