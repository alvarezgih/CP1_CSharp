namespace ProjetoMercado
{
    public class RepositorioProduto : IRepositorioProduto
    {
        private List<Produto> _produtos = new List<Produto>();

        public void SalvarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _produtos;
        }
    }

    public interface IRepositorioProduto
    {
    }
}