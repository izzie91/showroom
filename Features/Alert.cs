namespace showroom.Features;

public class Alert
{
    public void OnTemperatureChange(object sender, TemperatureChangeArgs e)
    {
        if (e.Temperature > 30)
        {
            Console.WriteLine("Alert: ¡Warning! temperature is upper regular values.");
        }
    }
}
