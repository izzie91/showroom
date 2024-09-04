using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showroom.Features;

public class TemperatureSensor
{
    private double _temperature;
    public event EventHandler<TemperatureChangeArgs> TemperatureChange;


    
    
    protected virtual void OnTemperatureChange(TemperatureChangeArgs e)
    {
        TemperatureChange?.Invoke(this, e);
    }

}

public class TemperatureChangeArgs : EventArgs
{
    public double Temperature { get; }
    public DateTime Date { get; set; }
}
