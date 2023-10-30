using MongoDB.Driver;

namespace MongoDbApi.Repositories;

public class MongoDbRepository
{
    public MongoClient client;
    
    public IMongoDatabase db;

    public MongoDbRepository()
    {
        client = new MongoClient("");
        
        db = client.GetDatabase("");
    }
}
