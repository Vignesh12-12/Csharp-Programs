// Create a class called LoginManager with two overloaded methods for handling
// user login:
// login(string email, string password) - Authenticates a user with their email
// and password.
// login(long mobileNumber, String password) - Authenticates a user with
// their mobile number and password.
// simulate different login scenarios.
// Solution Outline
// 1. Class (LoginManager): Define the overloaded methods login.
// 2. Method Implementations:
// ○ login(string email, string password): Authentication with email and
// password.
// ○ login(long mobileNumber, string password): Authentication with mobile
// number and password.
// 3. Instances: Create an instance of LoginManager and call the overloaded
// methods with appropriate arguments to demonstrate different login scenarios.
// Program:
// LoginManager.cs
internal class LoginManager
 {
     public void Login(string email, string password)
     {
          
         if (email == "user@gmail.com" && password == "pass@123")
         {
             Console.WriteLine("\nLogin successful using Email");
         }
         else
         {
             Console.WriteLine("\nInvalid email or password");
         }
     }

      
     public void Login(long mobileNumber, string password)
     {
          
         if (mobileNumber == 9876543210 && password == "pass@123")
         {
             Console.WriteLine("\nLogin successful using Mobile Number");
         }
         else
         {
             Console.WriteLine("\nInvalid mobile number or password");
         }
     }
 }
// Progam.cs
internal class Program
{
    private static void Main(string[] args)
    {
        LoginManager loginManager = new LoginManager();
        Console.WriteLine("Choose login method:");
        Console.WriteLine("1. Login with Email");
        Console.WriteLine("2. Login with Mobile Number");
        Console.Write("Enter choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("\nEnter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            loginManager.Login(email, password);
        }
        else if (choice == 2)
        {
            Console.Write("\nEnter Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            loginManager.Login(mobileNumber, password);
        }
        else
        {
            Console.WriteLine("\nInvalid choice!");
        }
    
}
}
// Output:
// Choose login method:
// 1. Login with Email
// 2. Login with Mobile Number
// Enter choice (1 or 2): 1
// Enter Email:abc@gmail.com
// Enter Password: pass@123
// Invalid email or password
//-------------------------------------------
// Choose login method:
// 1. Login with Email
// 2. Login with Mobile Number
// Enter choice (1 or 2): 2
// Enter Mobile Number: 9876543210
// Enter Password: pass@123
// Login successful using Mobile Number

