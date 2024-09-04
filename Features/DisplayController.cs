namespace showroom.Features;

public class DisplayController
{
    public void OnTemperatureChange(object sender, TemperatureChangeArgs e)
    {
        Console.WriteLine($"Display Controller: Temperature has changed. \n Current value: {e.Temperature}ºC at {e.Date}");
    }
}
