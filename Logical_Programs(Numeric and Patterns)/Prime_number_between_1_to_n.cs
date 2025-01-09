// Display prime number between 1 to n
// Input : N=15
// Output : 2,3,5,7,11,13
// Program:
 internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the nth number:");
        int n=int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        int k = 0,count=1;
        for (int i = 2; i <= n; i++)
        {
            bool isprime = true;
            for(int j = 2; j <=Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isprime = false;
                    count++;
                    break;
                }  
            }
            if(isprime)
                arr[k++] = i;
        }
        for(int i = 0;i <n-count; i++)
            Console.Write(arr[i]+" ");
    }
}
