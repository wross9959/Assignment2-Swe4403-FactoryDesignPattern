namespace src.cars.Civic;

// Factory for the Honda Civic 
class CivicFactory : CarCreator
{
    // Overrides the ICarFactory interface to create an Civic
    public override ICar CreateCar()
    {
        return new Civic();
    }
}