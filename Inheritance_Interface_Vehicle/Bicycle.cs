namespace Inheritance_Vehicle;

public class Bicycle : IVehicle, IBicycle
{
    public void Run()
    {
        Console.WriteLine("Bicycle run");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stop");
    }

    public void Acceleration()
    {
        Console.WriteLine("Bicycle accelerate");
    }

    public void Cycle()
    {
        Console.WriteLine("Bicycle cycle");
    }
}