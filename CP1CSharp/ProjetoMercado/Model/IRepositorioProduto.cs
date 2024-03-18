namespace ProjetoMercado.Model
{
    public interface IRepositorioProduto
    {
        void SalvarProduto(Produto produto);
        Produto BuscarProdutoPorId(int id);
        IEnumerable<Produto> ListarProdutos();
    }
}