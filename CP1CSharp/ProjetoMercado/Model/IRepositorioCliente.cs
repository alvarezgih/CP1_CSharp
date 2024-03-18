namespace ProjetoMercado.Model
{
    public interface IRepositorioCliente
    {
        void SalvarCliente(Cliente cliente);
        Cliente BuscarClientePorId(int id);
        IEnumerable<Cliente> ListarClientes();
    }
}
