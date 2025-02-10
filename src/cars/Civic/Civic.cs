namespace src.cars.Civic;

// The Civic car class
public class Civic : ICar
{
    // Override the ICar interface for shipping a Civic
    public string Ship()
    {
        return("Now shipping, a Honda Civic.");
    }

    // Checks the details for the Honda Civic
    public string Details()
    {
        return(  
            "Brand: Honda\n" +
            "Model: Civic\n"+
            "Year: 2025\n"+
            "Engine: 1.5L Turbo\n"+
            "Price: $24,000 CAD"
            );
    }
}