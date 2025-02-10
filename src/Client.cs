using src.cars;
using src.cars.Accord;
using src.cars.Civic;
using src.cars.Odyssey;

namespace src;

public class Client
{
    public void Run()
    {
        // Create a civic
        ClientCode(new CivicFactory());
        Console.WriteLine("\n====================\n");
        
        // Create an accord
        ClientCode(new AccordFactory());
        Console.WriteLine("\n====================\n");
        
        // Create an odyssey
        ClientCode(new OdysseyFactory());
        Console.WriteLine("\n====================\n");
    }

    void ClientCode(CarCreator car)
    {
        Console.WriteLine("Car Order received for the following:");
        Console.WriteLine(car.CarDetails());
        
        Console.WriteLine("Building...");
        Thread.Sleep(1000);
        Console.WriteLine(car.ShipCar());
    }
}