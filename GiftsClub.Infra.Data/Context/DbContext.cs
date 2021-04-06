using MongoDB.Driver;
using System.Configuration;

namespace GiftsClub.Infra.Data.Context
{
    public class DbContext
    {
        public const string CONNECTION_STRING_NAME = "GiftsClubDB";
        public const string DATABASE_NAME = "giftsclub";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static DbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.ToLower() + "s");
        }
    }
}
