namespace Design.Cohesion.InformationalCohesion;
public class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        // Code to add a product to the shopping cart
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        // Code to remove a product from the shopping cart
        products.Remove(product);
    }

    public decimal CalculateTotalPrice()
    {
        // Code to calculate the total price of the products in the shopping cart
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price;
        }

        return totalPrice;
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        // Adding products to the cart
        Product product1 = new Product { Name = "Product 1", Price = 10.99m };
        Product product2 = new Product { Name = "Product 2", Price = 19.99m };

        cart.AddProduct(product1);
        cart.AddProduct(product2);

        // Removing a product from the cart
        cart.RemoveProduct(product1);

        // Calculating the total price
        decimal totalPrice = cart.CalculateTotalPrice();
        Console.WriteLine("Total price: " + totalPrice);
    }
}