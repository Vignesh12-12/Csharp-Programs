// Write a program to:
// a. Accept an array of 10 integers from the user.
// b. Count the frequency of each element in the array.
// c. Display each element along with its frequency.
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 10 numbers:");
        int[] num = new int[10];
        int[] visited = new int[10];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            visited[i] = 0;
        }
        for (int i = 0; i < num.Length; i++)
        {
            if (visited[i] == 1)
                continue;

            int freq = 1;
            for (int j = i+1; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    freq++;
                    visited[j] = 1;
                }
            }
            Console.WriteLine($"frequency of {num[i]} is {freq}");
        }
    }
}
