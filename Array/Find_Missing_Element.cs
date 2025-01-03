// Create a program that:
// a. Accepts an array of n distinct integers in a specific range (e.g., from 1 to n).
// b. Identifies and displays the missing element from the range.
// Test Cases:
// Enter the size of the array: 5
// Enter the elements of the array: 1 2 4 5 6
// The missing number is: 3
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the size of the array");
        int n=int.Parse(Console.ReadLine());
        int[] arr= new int[n];
        Console.WriteLine("Enter the elements of the array");
        int expectedsum = 0, totalsum = 0;
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = int.Parse(Console.ReadLine());
            totalsum += arr[i];
        }
        for (int i = 1; i <= n+1; i++) {
            expectedsum += i;
        }
        int missing = expectedsum - totalsum;
        Console.WriteLine("The missing number is "+missing);  
    }
    }
