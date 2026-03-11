using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Commands;

public sealed class UnlockDoorCommand : ICommand
{
    private readonly DoorLock _door;

    public UnlockDoorCommand(DoorLock door)
    {
        _door = door;
    }

    public string Description => $"Unlock door '{_door.Name}'";

    public void Execute() => _door.Unlock();
}

