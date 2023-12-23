namespace Design.Cohesion.CommunicationalCohesion;
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class EmailSender
{
    public void SendEmail(Customer customer, string message)
    {
        // Code to send an email to the customer
        Console.WriteLine("Sending email to: " + customer.Email);
        Console.WriteLine("Message: " + message);
    }
}

public class CustomerService
{
    private EmailSender emailSender;

    public CustomerService()
    {
        emailSender = new EmailSender();
    }

    public void RegisterCustomer(Customer customer)
    {
        // Code to register the customer
        Console.WriteLine("Registering customer: " + customer.Name);

        // Send a welcome email to the customer
        string welcomeMessage = "Welcome, " + customer.Name + "! Thank you for registering.";
        emailSender.SendEmail(customer, welcomeMessage);
    }

    public void UpdateCustomerEmail(Customer customer, string newEmail)
    {
        // Code to update the customer's email
        Console.WriteLine("Updating email for customer: " + customer.Name);

        // Send an email notification about the email update
        string notificationMessage = "Dear " + customer.Name + ", your email has been updated to: " + newEmail;
        emailSender.SendEmail(customer, notificationMessage);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        CustomerService customerService = new CustomerService();

        // Register a new customer
        Customer newCustomer = new Customer { Name = "John Doe", Email = "john.doe@example.com" };
        customerService.RegisterCustomer(newCustomer);

        // Update the customer's email
        Customer existingCustomer = new Customer { Name = "Jane Smith", Email = "jane.smith@example.com" };
        string newEmail = "jane.smith.updated@example.com";
        customerService.UpdateCustomerEmail(existingCustomer, newEmail);
    }
}