namespace Design.Cohesion.LogicalCohesion;
public class UserManager
{
    public void CreateUser(string username, string password)
    {
        // Code to create a new user in the system
        Console.WriteLine("Creating user: " + username);
    }

    public void UpdateUser(string username)
    {
        // Code to update user information
        Console.WriteLine("Updating user: " + username);
    }

    public void DeleteUser(string username)
    {
        // Code to delete a user from the system
        Console.WriteLine("Deleting user: " + username);
    }

    public void GetUserDetails(string username)
    {
        // Code to retrieve user details
        Console.WriteLine("Getting details for user: " + username);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();

        string username = "john.doe";

        userManager.CreateUser(username, "password");
        userManager.UpdateUser(username);
        userManager.GetUserDetails(username);
        userManager.DeleteUser(username);
    }
}