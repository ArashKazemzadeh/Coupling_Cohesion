using CommunicationalCohesion;

User user = new() {
    Id = 1,
    UserName = "User1",
    Password = "123",
    Email = "User1@mail.com"
};

UserManagement userManagement = new ();
userManagement.RegisterUser(user);