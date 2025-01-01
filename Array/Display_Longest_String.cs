// Create a program that:
// a. Accepts 5 strings from the user and stores them in an array.
// b. Displays all the strings.
// c. Finds and displays the longest string.
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        string[] str=new string[5];
        Console.WriteLine("Enter 5 strings");
        for (int i = 0; i < str.Length; i++)
            str[i] = Console.ReadLine();
        Console.WriteLine("\nThe input strings are");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i]+" ");
        string longest = str[0];
        for (int i = 1; i < str.Length; i++)
            if (longest.Length < str[i].Length)
            {
                longest = str[i];
            }
        Console.WriteLine("\nThe longest string is:"+longest);

    } 
}
