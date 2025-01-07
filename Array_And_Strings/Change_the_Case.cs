// Write a program to change the case without using inbuilt functions.
// Sample Input: Hello, World!
// Sample Output: hELLO, wORLD!
Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a text:");
        String input = Console.ReadLine();
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++) { 
            char c = input[i];
            if(c>='A' && c <= 'Z')
            {
                result[i] = (char)(c+32);
            }
            else if(c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 32);
            }
            else
                result[i] = c;
        }
        Console.WriteLine("after changing the cases:\n" + new String(result));  
    }
}
