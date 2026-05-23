using Microsoft.EntityFrameworkCore;
using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;
using SegurosApi.Infrastructure.Context;

namespace SegurosApi.Infrastructure.Repositories
{
    public class ApoliceRepository : IApoliceRepository
    {
        private readonly SegurosApiDbContext _context;

        public ApoliceRepository(
            SegurosApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Apolice>> GetAll()
        {
            return await _context
                .Apolices
                .ToListAsync();
        }


        public async Task<Apolice?> GetById(Guid id)
        {
            return await _context
                .Apolices
                .FirstOrDefaultAsync(
                x => x.Id == id);
        }

        public async Task Add(
            Apolice apolice)
        {
            await _context.Apolices
                .AddAsync(apolice);

            await _context.SaveChangesAsync();
        }

        public async Task Update(
            Apolice apolice)
        {
            _context.Update(apolice);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var apolice =
                await GetById(id);

            if (apolice is null)
                return;

            _context.Remove(apolice);

            await _context.SaveChangesAsync();
    }
    }
}