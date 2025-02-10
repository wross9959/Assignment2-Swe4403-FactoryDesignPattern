namespace src.cars.Odyssey;

// Factory for the Honda Odyssey 
class OdysseyFactory : CarCreator
{
    // Overrides the ICarFactory interface to create an Odyssey
    public override ICar CreateCar()
    {
        return new Odyssey();
    }
}