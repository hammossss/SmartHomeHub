using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Devices;

namespace SmartHomeHub.Observers;

public interface IDeviceObserver
{
    void OnDeviceChanged(IDevice device, string message);
}

