using ProjetoMercado.Model;
using System;
using System.Collections.Generic;

public class Venda
{
    private int v;
    private DateTime now;

    public Venda(Cliente cliente, DateTime now)
    {
        Cliente = cliente;
        this.now = now;
    }

    public Venda(int v, DateTime now, Cliente cliente, List<Produto> produtos)
    {
        this.v = v;
        this.now = now;
        Cliente = cliente;
        Produtos = produtos;
    }

    public int Id { get; set; }
    public DateTime DataVenda { get; set; }
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; set; }
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.Preco;
        }
        return total;
    }

    internal void AdicionarProduto(Produto produto)
    {
        throw new NotImplementedException();
    }

    internal decimal CalcularValorTotal()
    {
        throw new NotImplementedException();
    }

    internal void FinalizarVenda()
    {
        throw new NotImplementedException();
    }
}