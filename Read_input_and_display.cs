//Write C# program to read name as input and display a welcome message.

Program:
using System;
public class Example
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter Name:");
        string Name=Console.ReadLine();
        Console.WriteLine ("Welcome "+Name);
    }
}
