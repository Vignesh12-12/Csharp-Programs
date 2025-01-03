// Create a C# program that:
// a. Accepts an array of n integers from the user.
// b. Asks the user to enter an element to delete.
// c. Deletes the element if it exists in the array, and shifts the remaining elements.
// d. Displays the updated array.
// Test case 1:
// Enter the size of the array: 5
// Enter the elements of the array: 10 20 30 40 50
// Enter the element to delete: 30
// Output: Updated array after deletion: 10 20 40 50
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the size of the array:");
        int n=int.Parse(Console.ReadLine());
        int[] arr= new int[n];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < arr.Length; i++)
            arr[i] = int.Parse(Console.ReadLine());
        Console.Write("Enter the element to delete:");
        int del=int.Parse(Console.ReadLine());
        bool flag=false;
        for(int i = 0;i < arr.Length; i++)
        {
            if(arr[i] == del)
            {
                for(int j = i;j<arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                flag = true;
            }
        }
        if (flag)
        {
            Console.WriteLine("updated array after deletion:");
            for (int i = 0; i < arr.Length - 1; i++)
                Console.Write(arr[i]+" ");
        }
        else
            Console.WriteLine("Element not found in the array");
    }
}
