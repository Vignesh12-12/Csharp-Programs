// ------Library Book System------
// Create a class Book that has properties for Title, Author, ISBN, and Price. Use a
// constructor to initialize these values. Implement a method to display the book details.
// Requirements:
// ● Use a constructor to initialize the properties.
// ● Create a method to display book details.
// Program:
internal class Book
 {
     string Title, Author;
     int ISBN, Price;
     public Book(string Title, string Author, int ISBN, int Price)
     {
         this.Title = Title;
         this.Author = Author;
         this.ISBN = ISBN;
         this.Price = Price;
     }
     public void Displayinfo()
     {
         Console.WriteLine("------Library Management System----");
         Console.WriteLine("Title:" + Title);
         Console.WriteLine("Author:"+Author);
         Console.WriteLine("ISBN:"+ISBN);
         Console.WriteLine("Price:"+Price);
     }
 }
internal class Program
{
    private static void Main(string[] args)
    {
        string Title, Author;
        int ISBN, Price;
        Console.WriteLine("Enter the Book Title");
        Title=Console.ReadLine();
        Console.WriteLine("Enter the Book Author");
        Author=Console.ReadLine();
        Console.WriteLine("Enter the Book ISBN");
        ISBN=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Book Price");
        Price=int.Parse(Console.ReadLine());
        Book b = new Book(Title,Author,ISBN,Price);
        b.Displayinfo();
    }
}
