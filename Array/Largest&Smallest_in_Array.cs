// Write a C# program to:
// a. Declare an integer array of size 10.
// b. Accept 10 values from the user and store them in the array.
// c. Display the array elements.
// d. Find and display the largest and smallest numbers in the array.
// Program:

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr=new int[10];
        Console.WriteLine("Enter the digits:");
        for (int i = 0; i < arr.Length; i++)
            arr[i]=int.Parse(Console.ReadLine());
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i]+" ");
        int largest = 0, smallest = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (largest < arr[i])
                largest = arr[i];
        }
        Console.WriteLine("\nlargest number:" + largest);
        for (int i = 0; i < arr.Length; i++)
        {
            if (smallest > arr[i])
                smallest = arr[i];
        }
        Console.WriteLine("smallest number:" + smallest);
    } 
}
