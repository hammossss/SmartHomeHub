using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;
using SmartHomeHub.Infrastructure;

namespace SmartHomeHub.Observers;

public sealed class LoggerObserver : IDeviceObserver
{
    public void OnDeviceChanged(IDevice device, string message)
    {
        Logger.Instance.Log($"{device.Name}: {message}");
    }
}

