using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Commands;

public sealed class TurnOnLampCommand : ICommand
{
    private readonly Lamp _lamp;

    public TurnOnLampCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public string Description => $"Turn ON lamp '{_lamp.Name}'";

    public void Execute() => _lamp.TurnOn();
}

