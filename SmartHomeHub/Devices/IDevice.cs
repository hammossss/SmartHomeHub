using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Devices;

public interface IDevice
{
    string Name { get; }
    string GetStatus();
}

