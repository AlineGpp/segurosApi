using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegurosApi.Application.Interfaces;
using SegurosApi.Domain.Entidades;
using SegurosApi.Domain.Interfaces;

namespace SegurosApi.Application.Services
{
    public class SeguroService : ISeguroService
    {
        private readonly ISeguroRepository _seguroRepository;
        public SeguroService(
            ISeguroRepository seguroRepository)
        {
            _seguroRepository = seguroRepository;
        }
        public Task<Seguro> CreateAsync(Seguro seguro)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Seguro>> GetAllAsync()
        {
            return  await _seguroRepository.GetAll();
        }
    
        public Task<Seguro> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Seguro seguro)
        {
            throw new NotImplementedException();
        }
    }
}