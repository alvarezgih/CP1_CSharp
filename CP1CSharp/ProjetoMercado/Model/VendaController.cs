namespace ProjetoMercado.Model
{
    public class VendaController
    {
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IRepositorioCliente _repositorioCliente; // Adicione essa dependência se necessário

        // Construtor
        public VendaController(IRepositorioProduto repositorioProduto, IRepositorioCliente repositorioCliente)
        {
            _repositorioProduto = repositorioProduto;
            _repositorioCliente = repositorioCliente;
        }

        // Método para realizar uma venda
        public void RealizarVenda(int clienteId, List<int> produtosIds)
        {
            Cliente cliente = BuscarClientePorId(clienteId);
            if (cliente != null)
            {
                List<Produto> produtos = new List<Produto>();
                foreach (int produtoId in produtosIds)
                {
                    Produto produto = _repositorioProduto.BuscarProdutoPorId(produtoId);
                    if (produto != null)
                    {
                        produtos.Add(produto);
                    }
                }
                // Lógica para criar a venda e atualizar o estoque
                Venda venda = new Venda(1, DateTime.Now, cliente, produtos);
                decimal total = venda.CalcularTotal();
                Console.WriteLine($"Venda realizada para {cliente.Nome} no valor de {total:C}");
            }
        }

        // Método protegido para buscar cliente por ID
        protected Cliente BuscarClientePorId(int clienteId)
        {
            // Lógica para buscar cliente por ID
            // Aqui você deve usar o repositório de cliente para buscar o cliente pelo ID
            // Exemplo de implementação fictícia:
            return _repositorioCliente.BuscarClientePorId(clienteId);
        }
    }
}
