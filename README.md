# DotNetBookShop
1) DotnetBookShop- team member: 2
2) All needed secret key for this project to work well include: 
(you can enter your key in appsetting.json or secrets.json)
"ConnectionStrings": {
    "DefaultConnection": ""
  },
  "Stripe": {
    "SecretKey": "",
    "PublishableKey": ""
  },
  "Facebook": {
    "AppId": "",
    "AppSecret": ""
  },
  "SendGrid": {
    "SecretKey": ""
  }
  # The admin account will be automatically created and can be used when first starting the project (in GettingStart1.DataAcess.DbInitializer.DbInitializer.cs)
  //if roles are not created, then we will create admin user as well 
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "test@gmail.com",
                    Email = "test@gmail.com",
                    Name = "Admin",
                    PhoneNumber = "99999999999",
                    StreetAddress = "9999",
                    City = "Houston",
                    State = "Tx",
                    PostalCode = "99999"
                }, "Admin123*").GetAwaiter().GetResult();
