using SegurosApi.Domain.Entidades;

namespace SegurosApi.Application.Interfaces;

public interface ISeguroService
{
    Task<Seguro> GetByIdAsync(Guid id);

    Task<IEnumerable<Seguro>> GetAllAsync();

    Task<Seguro> CreateAsync(Seguro seguro);

    Task UpdateAsync(Seguro seguro);

    Task DeleteAsync(Guid id);
}