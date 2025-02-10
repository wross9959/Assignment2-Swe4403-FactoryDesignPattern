namespace src.cars;

public abstract class CarCreator
{
    // Abstract class to be able to create different types of cars
    public abstract ICar CreateCar();

    // Get a cars information
    public string CarDetails()
    {
        var car = CreateCar();
        var result = car.Details();
        return result;
    }
    
    // Ship a car
    public string ShipCar()
    {
        var car = CreateCar();
        var result = car.Ship();
        return result;
    }
    
}