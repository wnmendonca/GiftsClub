using GiftsClub.Domain.Interfaces.Repositories;
using MongoDB.Driver;
using GiftsClub.Infra.Data.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Bson;

namespace GiftsClub.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private DbContext _dbContext = new DbContext();

        public async Task<TEntity> Get(string id)
        {
            var filter = Builders<TEntity>.Filter.Eq("Id", id);
            var collection = GetCollection<TEntity>();
            return await collection.Find(filter).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetMany(IEnumerable<string> ids)
        {
            var filter = Builders<TEntity>.Filter.Eq("Id", ids);
            var collection = GetCollection<TEntity>();
            return await collection.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var collection = GetCollection<TEntity>();
            return await collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task Add(TEntity item)
        {
            var collection = GetCollection<TEntity>();
            await collection.InsertOneAsync(item);
        }

        public async Task Update(string id, UpdateDefinition<TEntity> update)
        {
            var filter = new FilterDefinitionBuilder<TEntity>().Eq("Id", id);
            var collection = GetCollection<TEntity>();
            await collection.UpdateOneAsync(filter, update);
        }

        public async Task Delete(string id)
        {
            var filter = new FilterDefinitionBuilder<TEntity>().Eq("Id", id);
            var collection = GetCollection<TEntity>();
            await collection.DeleteOneAsync(filter);
        }

        private IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _dbContext.GetCollection<TEntity>();
        }
    }
}
