using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegurosApi.Domain.Entidades;

namespace SegurosApi.Domain.Interfaces
{
    public interface IApoliceRepository
    {
        Task<List<Apolice>> GetAll();

        Task<Apolice?> GetById(Guid id);

        Task Add(Apolice apolice);

        Task Update(Apolice apolice);

        Task Delete(Guid id);
    }
}
   