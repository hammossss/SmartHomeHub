using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Modes;

public sealed class SmartHomeContext
{
    public Lamp LivingRoomLamp { get; }
    public Thermostat HallThermostat { get; }
    public DoorLock FrontDoor { get; }

    public SmartHomeContext(Lamp livingRoomLamp, Thermostat hallThermostat, DoorLock frontDoor)
    {
        LivingRoomLamp = livingRoomLamp;
        HallThermostat = hallThermostat;
        FrontDoor = frontDoor;
    }
}

