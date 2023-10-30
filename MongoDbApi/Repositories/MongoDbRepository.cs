using MongoDB.Driver;

namespace MongoDbApi.Repositories;

public class MongoDbRepository
{
    public MongoClient client;
    
    public IMongoDatabase db;

    public MongoDbRepository()
    {
        DotNetEnv.Env.Load();
        
        var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
        
        client = new MongoClient(connectionString);
        
        db = client.GetDatabase("Inventory_steelnails");
    }
}