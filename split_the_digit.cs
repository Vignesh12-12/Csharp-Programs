// Write C# program to read a 2-digit number and split the digits.

Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a 2digit Number :");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number>=10 && number <= 99)
        {
            int tens = number / 10;
            int unit=number % 10;
            Console.WriteLine("First digit :" + tens);
            Console.WriteLine("Second digit :" + unit);
        }
        else
        {
            Console.WriteLine("Invalid output");
        }  
    }
}
