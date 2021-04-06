using GiftsClub.Domain.Interfaces.Repositories;
using GiftsClub.Domain.Interfaces.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> Get(string id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<TEntity>> GetMany(IEnumerable<string> ids)
        {
            return await _repository.GetMany(ids);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Add(TEntity item)
        {
            await _repository.Add(item);
        }

        public async Task Update(string id, UpdateDefinition<TEntity> update)
        {
            await _repository.Update(id, update);
        }

        public async Task Delete(string id)
        {
            await _repository.Delete(id);
        }
    }
}
