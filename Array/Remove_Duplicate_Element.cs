// Develop a program that:
// a. Accepts an array of n integers from the user.
// b. Removes any duplicate elements from the array.
// c. Displays the array with unique elements only.
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the size of the array:");
        int n=int.Parse(Console.ReadLine());
        int[] arr= new int[n];
        int[] visited = new int[n];
        int[] arr1 = new int[n];
        int count = 0;
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++) {
            arr[i] = int.Parse(Console.ReadLine());
            visited[i] = 0;
        }
        for(int i = 0; i < n; i++)
        {
            if (visited[i] == 1)
            {
                count++;
                continue;
            }
            
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[i]== arr[j])
                {
                    visited[j] = 1;
                    arr1[i] = arr[i];
                }
            }
        }
        Console.WriteLine("After removing duplicate values");
        for (int i = 0; i < arr1.Length-count; i++)
            Console.Write(arr1[i] + " ");
    }
}
