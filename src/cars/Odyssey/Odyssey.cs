namespace src.cars.Odyssey;

// The Odyssey car class
public class Odyssey : ICar
{
    
    // Override the ICar interface for shipping a Odyssey
    public string Ship()
    {
        return("Now shipping, a Honda Odyssey.");
    }

    // Checks the details for the Honda Odyssey
    public string Details()
    {
        return(  
            "Brand: Honda\n" +
            "Model: Odyssey\n" +
            "Year: 2025\n" +
            "Engine: 2.5L Turbo\n" +
            "Price: $36,000 CAD"
            );
    }
}