namespace src.cars.Accord;

// Factory for the Honda Accord 
class AccordFactory : CarCreator
{
    // Overrides the ICarFactory interface to create an Accord
    public override ICar CreateCar()
    {
        return new Accord();
    }
}