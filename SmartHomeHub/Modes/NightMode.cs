using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Commands;

namespace SmartHomeHub.Modes;

public sealed class NightMode : IHomeMode
{
    public string Name => "Night Mode";

    public IEnumerable<ICommand> BuildCommands(SmartHomeContext context)
    {
        return new ICommand[]
        {
            new TurnOffLampCommand(context.LivingRoomLamp),
            new SetTemperatureCommand(context.HallThermostat, 19),
            new LockDoorCommand(context.FrontDoor)
        };
    }
}

