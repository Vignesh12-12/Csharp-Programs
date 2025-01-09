// Check whether the given number is palindrome or not
// [A palindrome number is a number that is the same after the reverse.]
// Input : 121
// Output : Palindrome
// Input:123
// Output: Not Palindrome
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter a number:");
        int n = int.Parse(Console.ReadLine());
        int temp = n,rev=0;
        while (n > 0)
        {
            int rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
        }
        if (temp ==rev)
            Console.WriteLine("The number is palindrome");
        else
            Console.WriteLine("The number is not a palindrome");
    }
}
