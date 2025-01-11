// Find the sum of first 10 fibonacci series 0 1 1 2 3 5 8 …
// The Fibonacci sequence, is a series of numbers where each number is the sum of the two preceding ones. The sequence typically starts with 0 and 1
// Output : Sum of the first 10 Fibonacci numbers is: 88
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the nth series:");
        int n = int.Parse(Console.ReadLine());
        int n1=0,n2=1,sum=0;
        for(int i = 0; i < n; i++)
        { 
            sum+= n1;
            int temp = n1 + n2;
            n1 = n2;
            n2= temp;
        }
        Console.WriteLine($"Sum of the first {n} Fibonacci number is:{sum}"); 
    }
}
