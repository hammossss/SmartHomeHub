using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Devices;

public sealed class Lamp : DeviceBase
{
    public bool IsOn { get; private set; }

    public Lamp(string name) : base(name)
    {
    }

    public void TurnOn()
    {
        if (IsOn) return;
        IsOn = true;
        Notify("Lamp turned ON");
    }

    public void TurnOff()
    {
        if (!IsOn) return;
        IsOn = false;
        Notify("Lamp turned OFF");
    }

    public override string GetStatus()
        => $"{Name}: {(IsOn ? "ON" : "OFF")}";
}

