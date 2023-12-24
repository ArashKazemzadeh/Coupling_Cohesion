namespace ProceduralCohesion;
public class UserManagement
{
    public void AuthenticateUser()
    {
        EnterUsername();
        EnterPassword();
        ValidateCredentials();
        GrantAccess();
    }

    private void EnterUsername()
    {
        Console.WriteLine("1. Enter username");
        Console.ReadLine();
    }

    private void EnterPassword()
    {
        Console.WriteLine("2. Enter password");
        Console.ReadLine();
    }

    private void ValidateCredentials()
    {
        Console.WriteLine("3. Validate entered username and password");
    }

    private void GrantAccess()
    {
        Console.WriteLine("4. Grant access if credentials are valid");
    }
}
