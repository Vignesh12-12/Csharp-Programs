// Read a single digit number and display in words using switch case.

// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any digit from 1 to 9:");
        byte num=byte.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
        }
    } 
}
