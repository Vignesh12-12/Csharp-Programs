// Create a C# program that:
// a. Takes an array of n integers as input.
// b. Finds and displays the sum of all elements in the array.
// c. Calculates and displays the average of the array elements.
// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the no of inputs:");
        int no=int.Parse(Console.ReadLine());
        int[] arr=new int[no];
        Console.WriteLine("Enter the values:");
        for (int i = 0; i < no; i++)
            arr[i]=int.Parse(Console.ReadLine());
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < no; i++)
            Console.Write(arr[i]+" ");
        int sum = 0;
        for (int i = 0; i < no; i++)
                sum+=arr[i];
        Console.WriteLine("\nTotal:"+sum);
        Console.WriteLine("Average" + sum / arr.Length);
    } 
}
