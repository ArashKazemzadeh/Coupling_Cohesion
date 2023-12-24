namespace Control_Coupling;
public class ProductController
{
    public void ShowListOfProducts(bool isAdmin)
    {
        List<Product> products = new()
        {
            new Product { Id = 1, Name = "Bag", Quantity = 1},
            new Product { Id = 2, Name = "T-shirt", Quantity = 5},
            new Product { Id = 3, Name = "Mug", Quantity = 0},
            new Product { Id = 4, Name = "Keyboard", Quantity = 50},
            new Product { Id = 5, Name = "Pen", Quantity = 0},
        };
        if (isAdmin) products.Dump();
        else
        {
            products.Where(p => p.Quantity > 0).Dump();            
        }
    }
}
