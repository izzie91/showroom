namespace showroom.Features;

public class TemperatureSensor
{
    private double _temperature;
    public event EventHandler<TemperatureChangeArgs> TemperatureChange;

    public double Temperature
    {
        get { return _temperature; }
        set
        {
            if (_temperature != value)
            {
                _temperature = value;
                OnTemperatureChange(new TemperatureChangeArgs(_temperature, DateTime.Now));
            }
        }
    }

    protected virtual void OnTemperatureChange(TemperatureChangeArgs e)
    {
        TemperatureChange?.Invoke(this, e);
    }

}

public class TemperatureChangeArgs : EventArgs
{
    public double Temperature { get; set; }
    public DateTime Date { get; set; }

    public TemperatureChangeArgs (double temperature, DateTime date)
    {
        Temperature = temperature;
        Date = date;
    }
}
