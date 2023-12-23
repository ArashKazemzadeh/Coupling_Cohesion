namespace ContentCoupling;
public class UserManagement
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public void RegisterUser()
    {
        Console.WriteLine($"User: {UserName} is registered. Password is set to: {Password}");
    }
}
