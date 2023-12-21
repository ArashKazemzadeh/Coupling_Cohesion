namespace Design.Coupling.ContentCoupling;
public class Product
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
}

public class ShoppingCart
{
    private List<Product> _products;
    public ShoppingCart() => _products = new List<Product>();

    public void AddProduct(Product product) => _products.Add(product);

    public void CalculateTotal()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            // Code to calculate the total based on product price
            total += product.Price;
        }

        Console.WriteLine($"Total: {total}");
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        Product product1 = new Product { Name = "Item 1", Price = 10 };
        Product product2 = new Product { Name = "Item 2", Price = 20 };

        cart.AddProduct(product1);
        cart.AddProduct(product2);

        cart.CalculateTotal();
    }
}