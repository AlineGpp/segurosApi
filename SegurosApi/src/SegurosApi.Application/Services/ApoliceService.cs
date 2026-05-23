using SegurosApi.Application.Interfaces;
using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;

namespace SegurosApi.Application.Services;

public class ApoliceService : IApoliceService
{
    private readonly IApoliceRepository _repository;

    public ApoliceService(
        IApoliceRepository repository)
    {
        _repository = repository;
    }

    public Task<Apolice> CreateAsync(Apolice apolice)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Apolice>> GetAllAsync()
        => await _repository.GetAll();

    public Task<Apolice> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Apolice apolice)
    {
        throw new NotImplementedException();
    }
}