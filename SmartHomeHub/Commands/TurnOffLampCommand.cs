using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Commands;

public sealed class TurnOffLampCommand : ICommand
{
    private readonly Lamp _lamp;

    public TurnOffLampCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public string Description => $"Turn OFF lamp '{_lamp.Name}'";

    public void Execute() => _lamp.TurnOff();
}

