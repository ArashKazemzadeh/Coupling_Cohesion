using Dumpify;

namespace FunctionalCohesion;
public class Product
{
    public required int Id { get; set; }
    public string Name { get; set; }
}

public class ProductManagement
{
    public void AddProduct(List<Product> products,Product product)
    {
        products.Add(product);
        $"product {product.Name} was added.".Dump();
    }
    public void GetProductById(List<Product> products,int id)
    {
        products.SingleOrDefault(p => p.Id == id).Dump();
    }
    public void GetAllProducts(List<Product> products)
    {
        products.Dump();
    }
    public void DeleteProductById(List<Product> products,int id)
    {
        var product = products.SingleOrDefault(p => p.Id == id);
        products.Remove(product);
        $"product {product.Name} was deleted.".Dump();
    }
}
