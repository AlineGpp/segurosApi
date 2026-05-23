
using SegurosApi.Domain.Entidades;

namespace SegurosApi.Application
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(Guid id);

        Task<Cliente> CreateClienteAsync(Cliente cliente);

        Task<Cliente> UpdateClienteAsync(Cliente cliente);

        Task DeleteClienteAsync(Guid id);
    }
}