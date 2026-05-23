using Microsoft.EntityFrameworkCore;
using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;
using SegurosApi.Infrastructure.Context;

namespace SegurosApi.Infrastructure.Repositories
{
    public class SeguroRepository : ISeguroRepository
    {
        private readonly SegurosApiDbContext _context;

        public SeguroRepository(
            SegurosApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Seguro>> GetAll()
        {
            return await _context
                .Seguros
                .ToListAsync();
        }
        public async Task<Seguro?> GetById(Guid id)
        {
            return await _context
                .Seguros
                .FirstOrDefaultAsync(
                x => x.Id == id);
        }

        public async Task Add(
            Seguro seguro)
        {
            await _context.Seguros
                .AddAsync(seguro);

            await _context.SaveChangesAsync();
        }

        public async Task Update(
            Seguro seguro)
        {
            _context.Update(seguro);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var seguro =
                await GetById(id);

            if (seguro is null)
                return;

            _context.Remove(seguro);

            await _context.SaveChangesAsync();





        }
    }
}