using GiftsClub.Application.Interface;
using GiftsClub.Domain.Interfaces.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task<TEntity> Get(string id)
        {
            return await _serviceBase.Get(id);
        }

        public async Task<IEnumerable<TEntity>> GetMany(IEnumerable<string> ids)
        {
            return await _serviceBase.GetMany(ids);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _serviceBase.GetAll();
        }

        public async Task Add(TEntity item)
        {
            await _serviceBase.Add(item);
        }

        public async Task Update(string id, UpdateDefinition<TEntity> update)
        {
            await _serviceBase.Update(id, update);
        }

        public async Task Delete(string id)
        {
            await _serviceBase.Delete(id);
        }
    }
}
