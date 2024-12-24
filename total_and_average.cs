// Write program to read 2 subject marks as input and display total and average.

Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the subject marks");
        Console.Write("Subject 1:");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 2:");
        int sub2 = Convert.ToInt32(Console.ReadLine());
        int total = sub1 + sub2;
        double average = total / 2.0;
        Console.WriteLine("Total :" + total);
        Console.WriteLine("Average :" + average);

    }
}
