using ContentCoupling;

UserManagement userManagement = new() { 
    UserName = "User1",
    Password = "123"
};
userManagement.RegisterUser();

AccountManagement accountManagement = new();
accountManagement.ResetUserPassword(userManagement, "abc");