// Develop a program that:
// a. Accepts an array of 10 integers from the user (which may include positive and negative numbers).
// b. Counts and displays the number of positive and negative numbers in the array.
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the size of the array:");
        int n=int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int positive = 0, negative = 0;
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < n; i++)
        {
            if(arr[i]>=0)
                positive++;
            else negative++;
        }
        Console.WriteLine($"positive values={positive}\nnegative values={negative}");
    }
}
