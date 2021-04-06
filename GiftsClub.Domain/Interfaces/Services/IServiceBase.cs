using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetMany(IEnumerable<string> ids);
        Task<IEnumerable<TEntity>> GetAll();
        Task Add(TEntity item);
        Task Update(string id, UpdateDefinition<TEntity> update);
        Task Delete(string id);
    }
}
