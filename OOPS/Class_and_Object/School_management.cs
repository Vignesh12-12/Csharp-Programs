// Create a Student class to model the information of students in a school. 
//The class should contain properties such as Name, StudentId, and Grade, and methods 
//to perform actions like enrolling a student, updating their grade, and displaying their details.
// Program:
namespace Students
{
    internal class Student
    {
        String Name, Grade;
        int StudentID;
         public Student(String Name, int StudentID,String Grade)
        {
            this.Name = Name;
            this.StudentID = StudentID; 
            this.Grade = Grade;
        }
        public void updategrade(string newGrade)
        {
            Grade = newGrade;
            Console.WriteLine($"Grade updated to {newGrade} for Student {Name}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("----Student Details----");
            Console.WriteLine("Student Name:"+Name);
            Console.WriteLine("StudentID:" + StudentID);
            Console.WriteLine("Student Grade:"+Grade);
        }
    }
}
using Students;
internal class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student("Jack", 101, "A");
        s.DisplayDetails();
        s.updategrade("A+");
        s.DisplayDetails();
    }
}

// Output:
// ----Student Details----
// Student Name:Jack
// StudentID:101
// Student Grade:A
// Grade updated to A+ for Student Jack
// ----Student Details----
// Student Name:Jack
// StudentID:101
// Student Grade:A+
