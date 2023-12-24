namespace CommunicationalCohesion;
public class UserManagement
{
    public void RegisterUser(User user)
    {
        Console.WriteLine($"User: {user.UserName} was registered successfully.");
        SendLoginInfo(user);
    }
    public void SendLoginInfo(User user)
    {
        Console.WriteLine($"Login info for user {user.UserName} was emailed successfully.");
    }
}
