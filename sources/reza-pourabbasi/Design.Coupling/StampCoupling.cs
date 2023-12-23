namespace Design.Coupling.StampCoupling;
public class EmailSender
{
    public void SendEmail(string recipient, string subject, string message)
    {
        // Code to send an email
        Console.WriteLine($"Sending email to {recipient}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
    }
}

public class NotificationService
{
    private readonly EmailSender _emailSender;

    public NotificationService(EmailSender emailSender)
    {
        _emailSender = emailSender;
    }
    public void SendNotification(string recipient, string notification)
    {
        string subject = "Notification";
        string message = $"Dear {recipient},\n\n{notification}\n\nRegards,\nNotification Service";
        _emailSender.SendEmail(recipient, subject, message);
    }
}

public class Program
{
    public void Main(string[] args)
    {
        EmailSender emailSender = new EmailSender();
        NotificationService notificationService = new NotificationService(emailSender);

        string recipient = "example@example.com";
        string notification = "This is an important notification.";

        notificationService.SendNotification(recipient, notification);
    }
}