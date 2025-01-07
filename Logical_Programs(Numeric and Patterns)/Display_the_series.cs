// Write a program to display the series[2,15,41,80,132,197………].
Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the nth series:");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int val = 2;
        for (int i = 0; i < n; i++)
        {
             val=val+(13*i);
             arr[i]=val;
        }
        for(int i = 0;i < n; i++)
            Console.Write(arr[i]+" ");
        
    }
}

