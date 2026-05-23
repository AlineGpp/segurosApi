

using SegurosApi.Domain.Entidades;

namespace SegurosApi.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAll();

        Task<Cliente?> GetById(Guid id);

        Task Add(Cliente cliente);

        Task Update(Cliente cliente);

        Task Delete(Guid id);
    }
}