// -----Employee Payroll System-----
// Create a base class Employee with properties Name, EmployeeID, and BasicSalary. 
// Create a derived class Payroll that inherits from Employee and adds methods to calculate gross salary and net salary.
// 1. Base Class Employee:
// •	Properties: Name, EmployeeID, and BasicSalary.
// •	A method to input employee details.
// 2. Derived Class Payroll:
// •	Inherits from Employee.
// •	Adds methods to calculate and display the GrossSalary and NetSalary.
// Program:
//Employee.cs
namespace Employee_Details
{
    internal class Employee
    {
        private int Id;
        private string Name;
        public int Salary;
        public void Setdata(int Eid, string Ename, int Esal)
        {
            Id = Eid;
            Name = Ename;
            Salary = Esal;
        }
        public void DisplayData()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(" EMPLOYEE INFORMATION");
            Console.WriteLine($" ID : {Id}");
            Console.WriteLine($" NAME : {Name}");
            Console.WriteLine($" SALARY: Rs.{Salary}");
        }
    }
}
//Payroll.cs
namespace Employee_Details
{
    internal class Payroll:Employee
    {
        double Hra,Ta,Pf,Gross,Net;
        public void Calculate()
        {
            Hra = Salary * 40 / 100.0;
            Ta = Salary * 20 / 100.0;
            Pf = Salary * 12 / 100.0;
            Gross = Salary + Hra + Ta;
            Net = Gross - Pf;
        }
        public void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine($" HRA : Rs.{Hra}");
            Console.WriteLine($" TA : Rs.{Ta}");
            Console.WriteLine($" Gross : Rs.{Gross}");
            Console.WriteLine($" PF : Rs.{Pf}");
            Console.WriteLine($" Net Salary : Rs.{Net}");
        }
        }
}
//Program.cs
internal class Program
{
    private static void Main(string[] args)
    {
        string Name;
        int ID, Salary;
        Console.WriteLine("Enter the Employee Details:");
        Console.WriteLine("Enter the Employee ID:");
        ID=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Employee Name:");
        Name=Console.ReadLine();
        Console.WriteLine("Enter the Employee Salary:");
        Salary=int.Parse(Console.ReadLine());
        Payroll payment = new Payroll();
        payment.Setdata(ID,Name,Salary);
        payment.Calculate();
        payment.DisplayData();
    }
}

// Output:
// Enter the Employee Details:
// Enter the Employee ID:
// 101
// Enter the Employee Name:
// Jack
// Enter the Employee Salary:
// 50000
// -----------------------
// EMPLOYEE INFORMATION
// ID : 101
// NAME : Jack
// SALARY: Rs.50000
// HRA : Rs.20000
// TA : Rs.10000
// Gross : Rs.80000
// PF : Rs.6000
// Net Salary : Rs.74000


