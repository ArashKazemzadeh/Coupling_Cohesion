namespace Design.Coupling.TemporalCoupling;
public class Order
{
    public string OrderId { get; set; }
    public decimal TotalAmount { get; set; }
    // Other order properties
}

// OrderProcessor.cs
public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        ValidateOrder(order);
        SaveOrder(order);
        SendConfirmationEmail(order);
    }

    private void ValidateOrder(Order order)
    {
        // Code to validate the order
        Console.WriteLine("Validating order...");
    }

    private void SaveOrder(Order order)
    {
        // Code to save the order to the database
        Console.WriteLine("Saving order...");
    }

    private void SendConfirmationEmail(Order order)
    {
        // Code to send a confirmation email to the customer
        Console.WriteLine("Sending confirmation email...");
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            OrderId = "123456",
            TotalAmount = 100
        };

        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder(order);
    }
}