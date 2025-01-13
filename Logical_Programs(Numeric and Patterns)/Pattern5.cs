// Write a program to print the following Pattern.
//     *
//    ***
//   *****
//  *******
// *********
//  *******
//   *****
//    ***
//     *
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 5;
        for (int i = 1; i <=n; i++)
        {
            for(int k=0;k<=n-i-1; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <=i*2-1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = n; i >= 1; i--)
        {
            for (int k = 0; k <= n - i - 1; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i * 2 - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
