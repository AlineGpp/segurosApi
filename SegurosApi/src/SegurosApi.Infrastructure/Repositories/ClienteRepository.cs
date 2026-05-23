using Microsoft.EntityFrameworkCore;
using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;
using SegurosApi.Infrastructure.Context;

namespace SegurosApi.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SegurosApiDbContext _context;

        public ClienteRepository(
            SegurosApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context
                .Clientes
                .ToListAsync();
        }

        public async Task<Cliente?> GetById(Guid id)
        {
            return await _context
                .Clientes
                .FirstOrDefaultAsync(
                x => x.Id == id);
        }

        public async Task Add(
            Cliente cliente)
        {
            await _context.Clientes
                .AddAsync(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task Update(
            Cliente cliente)
        {
            _context.Update(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var cliente =
                await GetById(id);

            if (cliente is null)
                return;

            _context.Remove(cliente);

            await _context.SaveChangesAsync();
        }
    }
}