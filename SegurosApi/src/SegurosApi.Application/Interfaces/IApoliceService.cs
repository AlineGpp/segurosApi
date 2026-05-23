using SegurosApi.Domain.Entidades;

namespace SegurosApi.Application.Interfaces;

public interface IApoliceService
{
    Task<Apolice> GetByIdAsync(Guid id);

    Task<IEnumerable<Apolice>> GetAllAsync();

    Task<Apolice> CreateAsync(Apolice apolice);

    Task UpdateAsync(Apolice apolice);

    Task DeleteAsync(Guid id);
}