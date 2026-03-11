using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Commands;

public sealed class SetTemperatureCommand : ICommand
{
    private readonly Thermostat _thermostat;
    private readonly int _targetTempC;

    public SetTemperatureCommand(Thermostat thermostat, int targetTempC)
    {
        _thermostat = thermostat;
        _targetTempC = targetTempC;
    }

    public string Description => $"Set '{_thermostat.Name}' to {_targetTempC}C";

    public void Execute() => _thermostat.SetTemperature(_targetTempC);
}

