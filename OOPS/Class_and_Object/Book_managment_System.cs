// Book Management system
// Create a class Book that stores information about a book like title, author, and price. 
//Add methods to input the details, calculate a discount on the book (e.g., 10% discount), and display the book's details including the discounted price..
// Program:
namespace BookManagementSystem
{
    internal class Book
    {
        string Title, Author;
        double price,discount=10;
        public Book(string Title,string Author,double price) { 
            this.Title = Title;
            this.Author = Author;
            this.price = price;
        }
         public void displaybook()
        {
            Console.WriteLine("Book Title:" + Title);
            Console.WriteLine("Book Author:" + Author);
            Console.WriteLine("Book Price:" + price);
            Console.WriteLine("Discount:"+discount+"%");
            price = price - (price * discount / 100);
            Console.WriteLine("Price After Discount:" + price);
        }
    }
}
using BookManagementSystem;
internal class Program
{
    private static void Main(string[] args)
    {
        Book b = new Book("Harry Potter","J.k. Rowling",1000);
        b.displaybook();
    }
}

// Output:
// Book Title:Harry Potter
// Book Author:J.k. Rowling
// Book Price:1000
// Discount:10%
// Price After Discount:900
