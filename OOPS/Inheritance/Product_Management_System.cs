// Create a base class called Product with properties such as Name, Price, and Category. 
// Then, create derived classes for Clothing, Electronics, and Food, each with additional properties. 
// Implement methods to display product details and calculate discounts.
// Base Class (Product):
// ● Contains properties for Name, Price, and Category.
// ● Has a method DisplayDetails to print basic information and a method
// CalculateDiscount to calculate the price after applying a discount.
// Derived Classes:
// ● Clothing: Adds properties Size and Color.
// ● Electronics: Adds properties Brand and WarrantyPeriod, and overrides
//   CalculateDiscount to provide an additional discount.
// ● Food: Adds a property for ExpirationDate.
// Main Method:
// ● Creates instances of Clothing, Electronics, and Food.
// ● Displays their details and calculates their discounted prices.
// Program:
// Product.cs
internal class Product
 {
     private string Name, Category;
     public double Price;

     public Product(string name, double price,string category)
     {
         Name = name;
         Price = price;
         Category=category;
     }
     public void DisplayDetails()
     {
         Console.WriteLine("Name:" + Name);
         Console.WriteLine("Price:"+ Price);
         Console.WriteLine("Category:"+ Category);
     }
     public void CalculateDiscount()
     {
         double discount = 10;
         Price = Price-(Price * discount / 100.0);
         Console.WriteLine($"Price after Discounted {discount}% :"+Price);
     }
 }
// Clothing.cs
internal class Clothing:Product
 {
     private string Size, Color;

     public Clothing(string name, double price, string category,string size,string color)
         :base(name, price, category)
     { 
         Size = size;
         Color = color;
     }
     public void DisplayDetails()
     {
         base.DisplayDetails();
         Console.WriteLine("Size:" + Size);
         Console.WriteLine("Color:" + Color);
     }
 }
// Electronics.cs
internal class Electronics:Product
 {
     private string Brand; 
     private int WarrantyPeriod;

     public Electronics(string name,double price,string category,string brand,int warrantyPeriod)
         :base(name,price,category)
     {
         Brand = brand;
         WarrantyPeriod = warrantyPeriod;
     }
     public void DisplayDetails()
     {
         base.DisplayDetails();
         Console.WriteLine("Brand:"+Brand);
         Console.WriteLine("Warranty Period:"+ WarrantyPeriod+"Months");
     }

     public void CalculateDiscount()
     {
         double discount = 15;
         Price = Price-(Price * discount / 100.0);
         Console.WriteLine($"Price after Discounted {discount}% :" + Price);
     }
 }
// Food.cs:
internal class Food:Product
 {
     string ExpirationDate;

     public Food(string name, double price, string category,string expirationdate)
         :base(name, price, category)
     {
         ExpirationDate = expirationdate;
     }
     public void DisplayDetails()
     {
         base.DisplayDetails();
         Console.WriteLine("Expiration Date:" + ExpirationDate);
     }
     }
// Program.cs
internal class Program
{
    private static void Main(string[] args)
    {
        Clothing clothing = new Clothing("T-shirt", 500, "Clothing", "xl", "Blue");
        Electronics electronics = new Electronics("Smartphone", 20000, "Electronics", "MI", 24);
        Food food = new Food("Milk", 50, "Food", "25/01/2025");

        Console.WriteLine("Clothing Details:");
        clothing.DisplayDetails();
        clothing.CalculateDiscount();
        Console.WriteLine();

        Console.WriteLine("Electronics Details:");
        electronics.DisplayDetails();
        electronics.CalculateDiscount();
        Console.WriteLine();

        Console.WriteLine("Food Details:");
        food.DisplayDetails();
        food.CalculateDiscount();
    }
}

// Output:
// -------Clothing Details:-------
// Name:T-shirt
// Price:500
// Category:Clothing
// Size:xl
// Color:Blue
// Price after Discounted 10% :450
// --------Electronics Details:-------
// Name:Smartphone
// Price:20000
// Category:Electronics
// Brand:MI
// Warranty Period:24Months
// Price after Discounted 15% :17000
// -------Food Details:----------
// Name:Milk
// Price:50
// Category:Food
// Expiration Date:25/01/2025
// Price after Discounted 10% :45
