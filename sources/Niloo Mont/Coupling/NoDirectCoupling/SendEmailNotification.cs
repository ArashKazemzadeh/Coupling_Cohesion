namespace NoDirectCoupling;
public class SendEmailNotification : ISendNotification
{
    public void SendNotificationToUser(string message)
    {
        $"Sending email notification: {message}".Dump(message);
    }
}
