namespace src.cars.Accord;

// The Accord car class
public class Accord : ICar
{
    // Override the ICar interface for shipping a Accord
    public string Ship()
    {
        return("Now shipping, a Honda Accord.");
    }

    // Checks the details for the Honda Accord
    public string Details()
    {
        return(  
            "Brand: Honda\n"+
            "Model: Accord\n"+
            "Year: 2025\n"+
            "Engine: 2.5L Turbo\n"+
            "Price: $32,000 CAD"
            );
    }
}