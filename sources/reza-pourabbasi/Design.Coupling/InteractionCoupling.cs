namespace Design.Coupling.InteractionCoupling;
public class Notifier
{
    public void NotifyUser(string message)
    {
        // Code to notify the user
        Console.WriteLine("Notification: " + message);
    }
}

public class OrderProcessor
{
    private Notifier notifier;

    public OrderProcessor()
    {
        notifier = new Notifier();
    }

    public void ProcessOrder()
    {
        // Code to process the order

        // Notify the user
        notifier.NotifyUser("Order processed successfully");
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        OrderProcessor orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder();
    }
}