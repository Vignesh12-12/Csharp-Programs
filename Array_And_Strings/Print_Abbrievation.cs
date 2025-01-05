// Write a program to print the abbreviation of the given text.
//         Input                        Output
//      ----------------            ----------------
//     World Health Organization        WHO
//     Automatic Teller Machine         ATM
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a text:");
        String s = Console.ReadLine();
        String[] words = s.Split(' ');
        String output = "";
        foreach(String word in words)
        {
            if (!String.IsNullOrWhiteSpace(word))
                output += char.ToUpper(word[0]);
        }
        Console.WriteLine(output);
    }
}
