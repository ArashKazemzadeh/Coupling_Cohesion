namespace Design.Coupling.CommunicationalCoupling;
public class Customer
{
    public required string Name { get; set; }
    public required string Email { get; set; }
}

public class EmailSender
{
    public void SendEmail(Customer customer, string message)
    {
        // Code to send an email to the customer
        Console.WriteLine($"Sending email to {customer.Email}: {message}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer
        {
            Name = "John Doe",
            Email = "johndoe@example.com"
        };

        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(customer, "Hello, John! Your order has been shipped.");
    }
}