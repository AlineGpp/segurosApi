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
            return await _clienteRepository.GetById(id) ?? throw new Exception("Cliente não encontrado");
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.GetAll();
        }

        public async  Task<Cliente> CreateClienteAsync(Cliente cliente)
        {
             await  _clienteRepository.Add(cliente);
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
            return cliente;
        }

        public async Task DeleteClienteAsync(Guid id)
        {
            await _clienteRepository.Delete(id);
        }
    }
}