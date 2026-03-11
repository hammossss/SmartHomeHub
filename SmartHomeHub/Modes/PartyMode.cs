using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Commands;

namespace SmartHomeHub.Modes;

public sealed class PartyMode : IHomeMode
{
    public string Name => "Party Mode";

    public IEnumerable<ICommand> BuildCommands(SmartHomeContext context)
    {
        return new ICommand[]
        {
            new TurnOnLampCommand(context.LivingRoomLamp),
            new SetTemperatureCommand(context.HallThermostat, 22),
            new UnlockDoorCommand(context.FrontDoor)
        };
    }
}

