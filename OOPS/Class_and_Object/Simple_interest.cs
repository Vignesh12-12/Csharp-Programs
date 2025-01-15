// Simple Interest Calculator
// Create a class SimpleInterestCalculator that stores the principal amount, rate of interest, and time in years. 
//Add a method to calculate the simple interest (SI = P * R * T / 100) and display the calculated interest
// Program:
internal class SI_Calculator
{
    public double FindSimpleInterest(int p,int n,double r)
    {
        double Interest = (p * n * r) / 100;
        return Interest;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        SI_Calculator si=new SI_Calculator();
        double Interest=si.FindSimpleInterest(10000, 2, 4);
        Console.WriteLine("Simple Interest:"+Interest);
    }
}

// Output: Simple Interest:800.0