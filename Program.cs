using showroom.Features;

namespace Showroom;

internal class Program
{
    static void Main(string[] args)
    {
        var sensor = new TemperatureSensor();

        var storageSystem = new StorageSystem();
        var displayController = new DisplayController();
        var alertSystem = new Alert();

        // Register the events
        sensor.TemperatureChange += storageSystem.OnTemperatureChange;
        sensor.TemperatureChange += displayController.OnTemperatureChange;
        sensor.TemperatureChange += alertSystem.OnTemperatureChange;

        sensor.Temperature = 20;
        Console.WriteLine("----");
        sensor.Temperature = 35;
        Console.WriteLine("----");
        sensor.Temperature = 10;
        Console.WriteLine("----");
        sensor.Temperature = 32;

        sensor.TemperatureChange -= storageSystem.OnTemperatureChange;
        sensor.TemperatureChange -= displayController.OnTemperatureChange;
        sensor.TemperatureChange -= alertSystem.OnTemperatureChange;
    }
}
