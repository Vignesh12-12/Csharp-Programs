// Calculate Electricity Bill
 
//  Units Normal  |Charges Per Unit |Extra Charges per bill|
//    <=100       |     0           |        -
//    101 to 250  |     0.80        |        25
//    251 to 450  |     1.50        |        75
//    >450        |     2           |        100

// Program:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the units used :");
        int units = int.Parse(Console.ReadLine());
        double bill=0;

        if (units <=100 )
        {
            bill = 0;
        }
        else if(units >=101 && units<=250)
        {
            bill = (units - 100) * 0.80 + 25;
        }
        else if (units >= 251 && units <= 450)
        {
            bill = (units - 250) * 1.50 + 75 + (150 * 0.80);
        }
        else if (units>450)
        {
            bill = (units - 450) * 2 + 100 + (200 * 1.50) + (150 * 0.80);
        }
        else
        {
            Console.WriteLine(" enter the correct units");
        }
        Console.WriteLine("Total bill:"+bill);
    }
}
