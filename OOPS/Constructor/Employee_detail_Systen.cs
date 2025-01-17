// -----Employee Details System-----
// Create a class Employee with properties EmployeeID, Name, Designation, and Salary.Use a constructor to initialize 
// these properties. Write a method to display the Employee’s details.
// Requirements:
// ● Use a constructor to initialize EmployeeID, Name, Designation, and Salary.
// ● Create a method to display employee details.
// Program:
internal class Employee
 {
     string Name, Designation;
     int ID, Salary;
     public Employee(int ID, String Name,String Designation, int Salary)
     {
         this.ID = ID;
         this.Name = Name;   
         this.Designation = Designation;
         this.Salary = Salary;
     }
     public void Displayinfo()
     {
         Console.WriteLine("-----Employee Details------");
         Console.WriteLine(" Employee ID:" + ID);
         Console.WriteLine(" Employee Name:"+Name);
         Console.WriteLine(" Employee Designation:"+Designation); 
         Console.WriteLine(" Employee Salary:"+Salary);
     }
 }
private static void Main(string[] args)
 {
     string Name, Designation;
     int ID, Salary;
     Console.WriteLine("Enter the Employee Details:");
     Console.WriteLine("Enter the Employee ID:");
     ID=int.Parse(Console.ReadLine());
     Console.WriteLine("Enter the Employee Name:");
     Name=Console.ReadLine();
     Console.WriteLine("Enter the Employee Designation:");
     Designation=Console.ReadLine();
     Console.WriteLine("Enter the Employee Salary:");
     Salary=int.Parse(Console.ReadLine()); 
     Employee emp=new Employee(ID,Name,Designation,Salary);
     emp.Displayinfo();
 }

// Output:
// Enter the Employee Details:
// Enter the Employee ID:
// 101
// Enter the Employee Name:
// Jack
// Enter the Employee Designation:
// Manager
// Enter the Employee Salary:
// 50000
// -----Employee Details------
// Employee ID:101
// Employee Name:Jack
// Employee Designation:Manager
// Employee Salary:50000
