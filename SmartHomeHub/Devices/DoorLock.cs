using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Devices;

public sealed class DoorLock : DeviceBase
{
    public bool IsLocked { get; private set; }

    public DoorLock(string name) : base(name)
    {
        IsLocked = true; // rimligt default
    }

    public void Lock()
    {
        if (IsLocked) return;
        IsLocked = true;
        Notify("Door locked");
    }

    public void Unlock()
    {
        if (!IsLocked) return;
        IsLocked = false;
        Notify("Door unlocked");
    }

    public override string GetStatus()
        => $"{Name}: {(IsLocked ? "LOCKED" : "UNLOCKED")}";
}

