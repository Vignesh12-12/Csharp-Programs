// Create an abstract class called BankAccount that includes properties for
// AccountNumber, AccountHolder, and methods for Deposit, Withdraw, and
// GetBalance. Then, create derived classes SavingsAccount and
// CheckingAccount that implement any specific rules for those account types.
// Abstract Class (BankAccount):
//     ● Contains properties for AccountNumber, AccountHolder, and a
//     protected Balance.
//     ● Includes methods for depositing and withdrawing money, getting the
//     current balance, and an abstract method DisplayAccountDetails.
// Derived Classes:
//     ● SavingsAccount: Adds an InterestRate property and includes a
//     method AddInterest to calculate and deposit interest. Implements
//     DisplayAccountDetails.
//     ● CheckingAccount: Adds an OverdraftLimit property. Overrides
//     Withdraw to allow withdrawals beyond the balance up to the
//     overdraft limit. Implements DisplayAccountDetails.
// Main Method:
//     ● Creates instances of SavingsAccount and CheckingAccount.
//     ● Performs deposit and withdrawal operations and displays account
//     details after each operation.
// Program:
// BankAccount.cs
namespace BankManagementSystem
{
    internal abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder {  get; set; }
        protected double Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolder,double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }        
        public void Deposit(double amount)
        {
            if (amount >=100)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Deposited: {amount}. New Balance {Balance}");
            }
            else
            {
                Console.WriteLine("minimum amount to deposit :100");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or Invalid Amount");
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
        public abstract void DisplayAccountDetails();
    }
}
// SavingsAccount.cs
namespace BankManagementSystem
{
    internal class SavingsAccount:BankAccount
    {
        private double InterestRate { get; set; }
        public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestrate)
            : base(accountNumber,accountHolder, balance)
        { 
            InterestRate = interestrate;
        }
        public void AddInterest(double InterestRate)
        {
            double InterestAmount = Balance * InterestRate / 100.0;
            Balance += InterestAmount;
            Console.WriteLine($"Interest of{InterestAmount} is added.New Balance:{Balance}");
        }

        public override void DisplayAccountDetails()
        {
            Console.WriteLine("-----Savings Account Details-------");
            Console.WriteLine("AccountNumber:"+AccountNumber);
            Console.WriteLine("Accounholder:"+AccountHolder);
            Console.WriteLine("Balance:"+Balance);
            Console.WriteLine("Interest Rate:"+InterestRate);
        }
    }
}
// CheckingAccount.cs
namespace BankManagementSystem
{
    internal class CheckingAccount:BankAccount
    {
        public double OverdraftLimit { get; set; }
        public CheckingAccount(int accountNumber, string accountHolder, double balance, double overdraftLimit)
           : base(accountNumber, accountHolder, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public  void Withdraw(double amount)
        {
            if (amount > 0 && Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit or invalid amount.");
            }
        }
        public override void DisplayAccountDetails()
        {
            Console.WriteLine("Checking Account Details:");
            Console.WriteLine("Account Number:"+AccountNumber);
            Console.WriteLine("Account Holder:" +AccountHolder);
            Console.WriteLine("Balance:" +Balance);
            Console.WriteLine("Overdraft Limit:"+OverdraftLimit);
        }
    }
}
// Program.cs
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----Bank Management System----");
        Console.WriteLine("Savings Account");
        Console.WriteLine("Enter the Account Number:");
        int AccountNumber=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the AccountHolder Name:");
        string AccountHolder = Console.ReadLine();
        Console.WriteLine("Enter the Initial Balance:");
        double InitialBalance= double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the InterestRate:");
        double InterestRate= double.Parse(Console.ReadLine());
        SavingsAccount savings = new SavingsAccount(AccountNumber,AccountHolder,InitialBalance, InterestRate);
        savings.DisplayAccountDetails();
        Console.WriteLine("Enter the Amount to be deposit");
        double deposit=double.Parse(Console.ReadLine());
        savings.Deposit(deposit);;
        savings.AddInterest(InterestRate);
        Console.WriteLine("Enter the Amount to Withdraw");
        double Withdraw = double.Parse(Console.ReadLine());
        savings.Withdraw(Withdraw);
        savings.DisplayAccountDetails();

        Console.WriteLine("-----------------------------------------");

        CheckingAccount checking = new CheckingAccount(102, "Sparrow", 3000, 1000);
        checking.DisplayAccountDetails();
        checking.Deposit(5000);
        checking.Withdraw(7000);
        checking.Withdraw(2000);
        checking.DisplayAccountDetails();
    }
}

// Output:
// ----Bank Management System----
// Savings Account
// Enter the Account Number:
// 101
// Enter the AccountHolder Name:
// Jack
// Enter the Initial Balance:
// 5000
// Enter the InterestRate:
// 5
// Enter the Amount to be deposit
// 1000
// Deposited: 1000. New Balance 6000
// Interest of 300 is added. New Balance:6300
// Enter the Amount to Withdraw
// 2000
// Withdrawn: 2000. New Balance: 4300
// -----Savings Account Details-------
// Account Number: 101
// Account Holder Name: Jack
// Balance: 4300
// Interest Rate: 5
// -----------------------------------------
// Checking Account Details:
// Account Number: 102
// Account Holder: Sparrow
// Balance: 3000
// Overdraft Limit: 1000
// Deposited: 5000. New Balance 8000
// Withdrawn: 7000. New Balance: 1000
// Withdrawn: 2000. New Balance: -1000
// Checking Account Details:
// Account Number: 102
// Account Holder: Sparrow
// Balance: -1000
// Overdraft Limit: 1000