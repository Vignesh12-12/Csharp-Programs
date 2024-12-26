//  Write a program to find the year leap or not.

// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a Year :");
        int year = int.Parse(Console.ReadLine());
        if (year % 400 == 0 )
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else if(year%4==0 && year % 100 != 0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}
