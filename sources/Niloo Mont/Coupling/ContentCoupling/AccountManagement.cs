namespace ContentCoupling;
public class AccountManagement
{
    public void ResetUserPassword(UserManagement user, string newPassword)
    {
        Console.WriteLine($"Password for {user.UserName} was change and set to {newPassword}");
    }
}
