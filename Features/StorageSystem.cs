namespace showroom.Features;

public class StorageSystem
{
    public void OnTemperatureChange(object sender, TemperatureChangeArgs e)
    {
        Console.WriteLine($"Storage System: Temperature has changed. \n Current value: {e.Temperature}ºC at {e.Date}");
    }
}
