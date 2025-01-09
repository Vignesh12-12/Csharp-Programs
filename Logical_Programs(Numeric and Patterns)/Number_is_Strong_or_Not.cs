// Display the given number is Strong or not
// Test Cases :
// N=15-> [1!+5!]=[1+120]=121 not equal to 15 so number is not strong
// N=145-> [1!+4!+5!]=[1+24+120]=145 equal to 145 so number is strong.
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter a number:");
        int n=int.Parse(Console.ReadLine());
        int sum = 0, fact = 1;
        int temp = n;
        while (n > 0)
        {
            int rem = n % 10;
            for (int i = 1; i <= rem; i++)
            {
                fact *= i;
            }
            sum += fact;
            fact = 1;
            n = n / 10;
        }
        if (temp == sum)
            Console.WriteLine("The number is strong");
        else
            Console.WriteLine("The number is not so strong");
        
    }
}
