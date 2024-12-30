// Write a program that:
// a. Takes 10 integer inputs from the user.
// b. Sorts the array in ascending order.
// c. Displays the sorted array.
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
        for(int i=0;i< arr.Length-1; i++)
        {
            for(int j = 0; j < arr.Length-i-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j]= arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Array elements after sorted are:");
        for (int i = 0; i < no; i++)
            Console.Write(arr[i]+" ");
        
    } 
}
