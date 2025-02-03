//  Add 2 subject marks or 3 subject marks or 5 subject marks or 2 percentages
// ● Use method overloading
// ● Pass 2 subject marks =>Total(60,70);
// ● Pass 3 subject marks=>total(70,60,45);
// ● Pass 2 percentages =>Total(67.7,91.3);.
// Program:
internal class Program
{
    static void Total(int mark1, int mark2)
    {
        int total = mark1 + mark2;
        Console.WriteLine($"Total of 2 subject marks: {total}");
    }
    
    static void Total(int mark1, int mark2, int mark3)
    {
        int total = mark1 + mark2 + mark3;
        Console.WriteLine($"Total of 3 subject marks: {total}");
    }
    static void Total(int mark1, int mark2, int mark3, int mark4, int mark5)
    {
        int total = mark1 + mark2 + mark3 + mark4 + mark5;
        Console.WriteLine($"Total of 5 subject marks: {total}");
    }
    static void Total(double percentage1, double percentage2)
    {
        double total = percentage1 + percentage2;
        Console.WriteLine($"Total of 2 percentages: {total}%");
    }
    private static void Main(string[] args)
    {
       
        Total(60, 70);      
        Total(70, 60, 45);    
        Total(67.7, 91.3);    
        Total(80, 75, 90, 85, 95); 
    }
}

// Output:
// Total of 2 subject marks: 130
// Total of 3 subject marks: 175
// Total of 2 percentages: 159%
// Total of 5 subject marks: 425

