using MongoDbApi.Models;

namespace MongoDbApi.Repositories;

public interface IProductCollection
{
    Task InsertProduct(Products product);
    
    Task UpdateProduct(Products product);
    
    Task DeleteProduct(string id);
    
    Task <List<Products>> GetAllProducts();
    
    Task<Products> GetProductById(string id);
}