// Write a program to read a number and split its digits.
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num=int.Parse(Console.ReadLine());
        Console.WriteLine("the digits in the number are:");
        while (num > 0)
        {
            int digit = num % 10;
            Console.WriteLine(digit);
            num = num / 10;
        }
    }
}
