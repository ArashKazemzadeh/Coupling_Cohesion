namespace NoDirectCoupling;
public class SendSMSNotification : ISendNotification
{
    public void SendNotificationToUser(string message)
    {
        $"Sending sms notification: {message}".Dump(message);
    }
}
