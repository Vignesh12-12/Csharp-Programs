// Write a program to find a number of spaces & words in a sentence.
// Sample Input: Hello world! This is a test.
// Sample Output:
// Number of spaces: 5
// Number of words: 6
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a text:");
        String input = Console.ReadLine();
        int spacecount = 0, wordcount = 0;
        bool isword = false;
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == ' ')
            {
                spacecount++;
                isword = false;
            }
            else
            {
                if (isword==false)
                {
                    wordcount++;
                    isword = true;
                }
            }
        }
        Console.WriteLine("number of spaces:" + spacecount);
        Console.WriteLine("number of words:"+wordcount);
    }
}
