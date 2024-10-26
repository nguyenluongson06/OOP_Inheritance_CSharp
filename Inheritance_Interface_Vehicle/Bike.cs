namespace Inheritance_Vehicle;

public class Bike : IVehicle, IBike
{
    public void Run()
    {
        Console.WriteLine("Bike run");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stop");
    }

    public void Acceleration()
    {
        Console.WriteLine("Bike accelerate");
    }

    public void StartEngine()
    {
        Console.WriteLine("Bike start engine");
    }
}