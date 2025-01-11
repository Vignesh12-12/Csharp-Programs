// Write a program to print the following Pattern
// 1
// 2 3
// 4 5 6
// 7 8 9 10
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4,k=1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(k + " ");
                k++;
            }
            Console.WriteLine();
        }
    }
}
