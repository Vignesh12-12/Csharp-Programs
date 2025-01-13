// Write a program to print the following Pattern.
// *   *
//  * *
//   *
//  * *
// *   *
 
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 5;
        for (int i = 1; i <=n; i++)
        {
            for (int j = 1; j <=n; j++)
            {
                if (i == j||i+j==n+1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        } 
    }
}
