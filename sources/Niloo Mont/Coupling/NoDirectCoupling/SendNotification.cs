namespace NoDirectCoupling;
public class SendNotification : ISendNotification
{
    public void SendNotificationToUser(string message)
    {
        $"Sending notification: {message}".Dump(message);
    }
}
