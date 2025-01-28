// ----Payment Processing System----
// Create an interface IPayment that includes a method for processing payments
// and implement two types of payment methods: CreditCardPayment and PayPalPayment.
// Interface Definition: IPayment specifies a method for processing payments
// Class Implementation: CreditCardPayment and PayPalPayment provide
//                       their specific implementations for processing payments.
// Using the Interface: In the Main method, we can easily switch betweendifferent payment methods 
//                      without modifying the code that initiates thepayment process.
// Program:
// IPayment.cs
namespace PaymentProcessSystem
{
    internal interface IPayment
    {
        void ProcessPayment(double amount);
    }
}
// CreditCardPayment.cs

namespace PaymentProcessSystem
{
    internal class CreditCardPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            Console.WriteLine("Payment successful via Credit Card.");
        }
    }
}
// PaypalPayment.cs

namespace PaymentProcessSystem
{
    internal class PayPalPayment
    {
        public void ProcessPayment(double amount)
        {
            
            Console.WriteLine($"Processing PayPal payment of {amount}...");
            Console.WriteLine("Payment successful via PayPal.");
        }
    }
}
// Program.cs
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Select Payment Method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. PayPal");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the payment amount:");
        double amount = double.Parse(Console.ReadLine());
        if (choice == 1)
        {
            CreditCardPayment credit = new CreditCardPayment();
            credit.ProcessPayment(amount);
        }
        else if (choice == 2)
        {
            PayPalPayment paypal= new PayPalPayment();
            paypal.ProcessPayment(amount);
        }
        else
        {
            Console.WriteLine("Invalid payment method.");
        }
    }
}
// Output:
// Select Payment Method:
// 1. Credit Card
// 2. PayPal
// 1
// Enter the payment amount:
// 100
// Processing credit card payment of 100
// Payment successful via Credit Card.

