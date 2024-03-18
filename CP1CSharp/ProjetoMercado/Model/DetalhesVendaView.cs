using System;

// View para mostrar os detalhes de uma venda
public class DetalhesVendaView
{
    // Método para mostrar os detalhes de uma venda na tela
    public void MostrarDetalhesVenda(Venda venda)
    {
        Console.WriteLine("Detalhes da Venda:");
        Console.WriteLine($"ID: {venda.Id}");
        Console.WriteLine($"Data da Venda: {venda.DataVenda}");
        Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
        Console.WriteLine("Produtos:");
        foreach (var produto in venda.Produtos)
        {
            Console.WriteLine($" - ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
        }
        Console.WriteLine($"Total da Venda: {venda.CalcularTotal():C}");
    }
}