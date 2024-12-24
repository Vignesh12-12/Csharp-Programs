// Write C# program swap 2 numbers using arithmetic operators.

Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the Numbers");
        Console.Write("Number 1:");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2:");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        Num1 = Num1 + Num2;
        Num2= Num1 - Num2;
        Num1= Num1 - Num2;
        Console.WriteLine("After Swapping");
        Console.WriteLine("Number 1:"+Num1);
        Console.WriteLine("Number 2:"+Num2);
    }
}
