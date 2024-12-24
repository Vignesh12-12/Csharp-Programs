// Write C# program to display your name and qualification in separate lines.

Program:
using System;
public class Example
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter Name:");
        string Name=Console.ReadLine();
        Console.WriteLine ("Enter the Qualification:");
        string qual=Console.ReadLine();
        Console.WriteLine("Name:"+Name+"\nQualification:"+qual);
    }
}
