// The Book class will have overloaded methods to display book details based
// on different inputs, such as the title, title with author, and title with author
// and year.
// Method Overloading: The Book class includes multiple DisplayInfo
// methods, allowing different levels of detail to be displayed depending on
// the available information.
// Program:
// Book.cs:
internal class Book
{
    private string Title;
    private string Author;
    private int Year;
    public Book(string title, string author, int year)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("\nBook Title: " + Title);
    }
    public void DisplayInfo(string title)
    {
        if (title == Title)
        {
            Console.WriteLine("\nBook Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }
        else
        {
            Console.WriteLine("\nBook not found!");
        }
    }
    public void DisplayInfo(string title, string author)
    {
        if (title == Title && author == Author)
        {
            Console.WriteLine("\nBook Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year: " + Year);
        }
        else
        {
            Console.WriteLine("\nBook not found!");
        }
    }
}
// Program.cs:
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();
        Console.Write("Enter Year of Publication: ");
        int year=int.Parse(Console.ReadLine());
        Book myBook = new Book(title, author, year);
        Console.WriteLine("\nChoose an option to display book details:");
        Console.WriteLine("1. Show only Title");
        Console.WriteLine("2. Show Title and Author");
        Console.WriteLine("3. Show Full Details (Title, Author, Year)");
        Console.Write("Enter your choice (1/2/3): ");
        int choice=int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            myBook.DisplayInfo();
        }
        else if (choice == 2)
        {
            Console.Write("\nEnter Book Title to search: ");
            string searchTitle = Console.ReadLine();
            myBook.DisplayInfo(searchTitle);
        }
        else if (choice == 3)
        {
            Console.Write("\nEnter Book Title to search: ");
            string searchTitleFull = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            string searchAuthor = Console.ReadLine();
            myBook.DisplayInfo(searchTitleFull, searchAuthor);
        }
        else
        {
            Console.Write("Invalid choice! Enter 1, 2, or 3: ");
        }
    }
}

// Output:
// Enter Book Title: C# Programming
// Enter Author Name: John Doe
// Enter Year of Publication: 2021
// Choose an option to display book details:
// 1. Show only Title
// 2. Show Title and Author
// 3. Show Full Details (Title, Author, Year)
// Enter your choice (1/2/3): 1
// Book Title: C# Programming
// -------------------------------------------
// Enter Book Title: C# Programming
// Enter Author Name: John Doe
// Enter Year of Publication: 2021
// Choose an option to display book details:
// 1. Show only Title
// 2. Show Title and Author
// 3. Show Full Details (Title, Author, Year)
// Enter your choice (1/2/3): 2
// Enter Book Title to search: C# Programming
// Book Title: C# Programming
// Author: John Doe
// -------------------------------------------
// Enter Book Title: C# Programming
// Enter Author Name: John Doe
// Enter Year of Publication: 2021
// Choose an option to display book details:
// 1. Show only Title
// 2. Show Title and Author
// 3. Show Full Details (Title, Author, Year)
// Enter your choice (1/2/3): 3
// Enter Book Title to search: C# Programming
// Enter Author Name: John Doe
// Book Title: C# Programming
// Book Author: John Doe
// Year of Publication: 2021
