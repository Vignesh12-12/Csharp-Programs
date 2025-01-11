// Write a program to print the following Pattern
// D
// DO
// DOT
// DO
// D.

// Program:
 internal class Program
{
    private static void Main(string[] args)
    {
        int n = 3;
        char[] arr = { 'D', 'O', 'T' };
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(arr[j] + " ");
               
            }
            Console.WriteLine();
            
        }
        for (int i = n - 2; i >= 0; i--)
        {
            for (int k = 0; k <= i; k++)
                Console.Write(arr[k] + " ");
            Console.WriteLine();
        }
    }
}
