using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;


namespace SegurosApi.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> GetClienteByIdAsync(Guid id)
        {
            return await _clienteRepository.GetById(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.GetAll();
        }

        public Task<Cliente> CreateClienteAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClienteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}