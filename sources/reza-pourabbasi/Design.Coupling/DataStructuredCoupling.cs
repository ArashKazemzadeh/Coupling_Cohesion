namespace Design.Coupling.DataStructuredCoupling;
// Customer.cs
public class Customer
{
    public required string Name { get; set; }
    public required string Email { get; set; }
}

// Order.cs
public class Order
{
    public required string OrderNumber { get; set; }
    public required decimal TotalAmount { get; set; }
}

// OrderProcessor.cs
public class OrderProcessor
{
    public void ProcessOrder(Order order, Customer customer)
    {
        // Code to process the order using customer information
        Console.WriteLine($"Processing order {order.OrderNumber} for customer {customer.Name}");
        Console.WriteLine($"Total amount: {order.TotalAmount}");
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer
        {
            Name = "John Doe",
            Email = "johndoe@example.com"
        };

        Order order = new Order
        {
            OrderNumber = "12345",
            TotalAmount = 100.0m
        };

        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder(order, customer);
    }
}