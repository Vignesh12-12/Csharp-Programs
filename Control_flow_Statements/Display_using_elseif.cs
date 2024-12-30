// Display number between 1 to 50
// If number id divisible by 3 then display as ‘Angry’
// If number id divisible by 5 then display as ‘Bird’
// If number id divisible by 3 &amp; 5 then display as ‘Angry Bird’
// Otherwise display the number

// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any number between 1 to 50: ");
        int num=int.Parse(Console.ReadLine());
        if(num<0 || num > 50)
        {
            Console.WriteLine("number is invalid");
        }
        else
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Angry Bird");
            }
            else if(num % 3 == 0)
            {
                 Console.WriteLine("Angry");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Bird");
            }
        }
    }
}
