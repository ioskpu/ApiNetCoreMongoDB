using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbApi.Models;

namespace MongoDbApi.Repositories;

public class ProductCollection: IProductCollection
{
    internal MongoDbRepository _repository = new MongoDbRepository();
    
    private IMongoCollection<Products> Collection;
    
    public ProductCollection()
    {
        Collection = _repository.db.GetCollection<Products>("Products");
    }
    
    public async Task InsertProduct(Products product)
    {
        await Collection.InsertOneAsync(product);
    }

    public async Task UpdateProduct(Products product)
    {
        var filter = Builders<Products>.Filter.Eq(s => s.Id, product.Id);
        
        await Collection.ReplaceOneAsync(filter, product);
    }

    public async Task DeleteProduct(string id)
    {
        var filter = Builders<Products>.Filter.Eq(s => s.Id, new ObjectId(id));
        await Collection.DeleteOneAsync(filter);
    }

    public async Task<List<Products>> GetAllProducts()
    {
        return await Collection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task<Products> GetProductById(string id)
    {
        return await Collection.FindAsync(
            new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
    }
}