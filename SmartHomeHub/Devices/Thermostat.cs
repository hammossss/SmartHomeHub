using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Devices;

public sealed class Thermostat : DeviceBase
{
    public int TemperatureC { get; private set; }

    public Thermostat(string name, int initialTempC = 20) : base(name)
    {
        TemperatureC = initialTempC;
    }

    public void SetTemperature(int temperatureC)
    {
        if (TemperatureC == temperatureC) return;

        var old = TemperatureC;
        TemperatureC = temperatureC;

        Notify($"Thermostat changed from {old}C to {TemperatureC}C");
    }

    public override string GetStatus()
        => $"{Name}: {TemperatureC}C";
}

