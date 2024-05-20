using MongoDB.Driver;
using ReastEasySpotify.Database.Mongo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Database.Mongo
{
    public class MongoDBContext
    {

        public async Task MongoService()
        {
            MongoSecret mongoSecret = new();

            MongoClient client = new(mongoSecret.ConnectionString());
            IMongoDatabase mongoDb = client.GetDatabase(mongoSecret.GetDatabaseName());
           // IMongoCollection<Person> collection = mongoDb.GetCollection<Person>(mongoSecret.GetCollectionName());

           // await PlaylistItemInMongo(collection);
        }

        public async Task PlaylistItemInMongo(IMongoCollection<Person> collection)
        {
            Person person = new() { name = "Bob", description = "Test User" };

            await collection.InsertOneAsync(person);

            IAsyncCursor<Person> results = await collection.FindAsync(_ => true);

            foreach (Person item in results.ToList())
            {
                Console.WriteLine($"{item.id}: {item.name}");
            }
        }


    }
}
