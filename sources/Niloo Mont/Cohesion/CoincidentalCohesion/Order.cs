using Dumpify;

namespace CoincidentalCohesion;
public class Order
{
    public int OrderId { get; }
    public List<Product> Products { get; }

    public Order(int orderId)
    {
        OrderId = orderId;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public void DisplayOrderDetails()
    {
        $"Order ID: {OrderId}".Dump();
        Console.WriteLine("Products:");

        foreach (var product in Products)
        {
            product.Dump();
        }

        $"Total Price: {CalculateTotal():C}".Dump();
    }
}
