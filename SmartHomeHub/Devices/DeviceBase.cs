using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Observers;

namespace SmartHomeHub.Devices;

public abstract class DeviceBase : IDevice
{
    private readonly List<IDeviceObserver> _observers = new();

    public string Name { get; }

    protected DeviceBase(string name)
    {
        Name = name;
    }

    public void Attach(IDeviceObserver observer) => _observers.Add(observer);
    public void Detach(IDeviceObserver observer) => _observers.Remove(observer);

    protected void Notify(string message)
    {
        foreach (var obs in _observers)
        {
            obs.OnDeviceChanged(this, message);
        }
    }

    public abstract string GetStatus();
}

