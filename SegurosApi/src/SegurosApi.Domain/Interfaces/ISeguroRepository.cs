using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegurosApi.Domain.Entidades;

namespace SegurosApi.Domain.Interfaces
{
    public interface ISeguroRepository
    {
         Task<List<Seguro>> GetAll();

        Task<Seguro?> GetById(Guid id);

        Task Add(Seguro seguro);

        Task Update(Seguro seguro);

        Task Delete(Guid id);
    }
}