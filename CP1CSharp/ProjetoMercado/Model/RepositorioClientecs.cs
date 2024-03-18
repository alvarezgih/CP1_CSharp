namespace ProjetoMercado.Model
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public Cliente BuscarClientePorId(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return _clientes;
        }
    }
}
