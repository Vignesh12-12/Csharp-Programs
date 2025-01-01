// Write a C# program to:
// a. Allow the user to input an array of n integers.
// b. Accept a number from the user to search for in the array.
// c. Implement a linear search and display the index of the number if found;
// otherwise, display a message saying the number is not in the array.
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
        Console.WriteLine("Enter the number to search:");
        int number=int.Parse(Console.ReadLine());
        bool flag = false;
        int index=0;
        for (int i = 0; i < no; i++)
        {
            if (number == arr[i])
            {
                flag = true;
                index = i;
                break;
            }
        }
        if (true)
            Console.WriteLine($"The number is found and the index of the number is {index}");
        else
            Console.WriteLine("The number is not in the array");
    } 
}
