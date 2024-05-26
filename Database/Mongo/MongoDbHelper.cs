using MongoDB.Driver;

namespace ReastEasySpotify.Database.Mongo
{
    public class MongoDbHelper<T>
    {
        private readonly IMongoCollection<T> _collection;

        public MongoDbHelper(string collectionName)
        {
            MongoSecret mongoSecret = new();
            MongoClient client = new(mongoSecret.ConnectionString());
            IMongoDatabase mongoDb = client.GetDatabase(mongoSecret.GetDatabaseName());
            _collection = mongoDb.GetCollection<T>(collectionName);
        }

        public IMongoCollection<T> GetCollection()
        {
            return _collection;
        }
    }
}
