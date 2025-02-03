// The Vehicle class will have a method called Describe, which will be
// overridden in both the Car and Bicycle classes to provide specific
// descriptions.
// Method Overriding: The Describe method in the Vehicle class is marked as
// virtual, allowing it to be overridden in derived classes. Both Car and Bicycle
// provide specific implementations of this method.
// Program:
class Vehicle
{
    public virtual void Describe()
    {
        Console.WriteLine("This is a vehicle.");
    }
}
class Car : Vehicle
{
    public override void Describe()
    {
        Console.WriteLine("This is a car. It has four wheels and runs on fuel.");
    }
}
class Bicycle : Vehicle
{
    public override void Describe()
    {
        Console.WriteLine("This is a bicycle. It has two wheels and is powered by pedaling.");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter vehicle type (Car/Bicycle): ");
        string input = Console.ReadLine().ToLower();
        if (input == "car")
        {
            Car car = new Car();
            car.Describe(); 
        }
        else if (input == "bicycle")
        {
            Bicycle bicycle = new Bicycle();
            bicycle.Describe(); 
        }
        else
        {
            Console.WriteLine("Invalid vehicle type. Displaying general vehicle info.");
            Vehicle vehicle = new Vehicle();
            vehicle.Describe(); 
        }
    }
}
// Output:
// Enter vehicle type (Car/Bicycle): Car
// This is a car. It has four wheels and runs on fuel.
// Enter vehicle type (Car/Bicycle): Bicycle
// This is a bicycle. It has two wheels and is powered by pedaling.
// Enter vehicle type (Car/Bicycle): Truck
// Invalid vehicle type. Displaying general vehicle info.

