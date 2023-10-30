using MongoDB.Driver;

namespace MongoDbApi.Repositories;

public class MongoDbRepository
{
    public MongoClient client;
    
    public IMongoDatabase db;

    public MongoDbRepository()
    {
        client = new MongoClient("mongodb://Inventory_steelnails:0c6457818bfd2d41de34ead6c0c5e44bfd676ca0@yx2.h.filess.io:27018/Inventory_steelnails");
        
        db = client.GetDatabase("Inventory_steelnails");
    }
}