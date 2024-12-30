// Write a program to check given number is Odd or even with runtime inputs.

// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a Number :");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is an even number");
        }
        else
        {
            Console.WriteLine($"{num} is an odd number");

        }
    }
}
