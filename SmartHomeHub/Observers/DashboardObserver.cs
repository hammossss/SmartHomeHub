using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Observers;

public sealed class DashboardObserver : IDeviceObserver
{
    public void OnDeviceChanged(IDevice device, string message)
    {
        Console.WriteLine($"[DASHBOARD] {device.Name}: {message} | Status: {device.GetStatus()}");
    }
}

