// Write a program to avoid special characters.
// Sample Input:hello...!,"Good Morning",Have a Nice day
// Sample Output:hello Good Morning Have a Nice day

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
            if((c>='A' && c <= 'Z') || (c >= 'a' && c <= 'z')||c==' ')
            {
                result[i] = c;
            } 
        }
        Console.WriteLine("after removing special character:\n" + new String(result));  
    }
}
