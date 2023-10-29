using MongoDB.Driver;

namespace MongoDbApi.Repositories;

public class MongoDbRepository
{
    public MongoClient client;
    
    public IMongoDatabase db;

    public MongoDbRepository()
    {
        client = new MongoClient("mongodb://localhost:27017");
        
        db = client.GetDatabase("Inventory");
    }
}