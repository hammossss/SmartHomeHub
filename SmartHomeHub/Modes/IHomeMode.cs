using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeHub.Commands;

namespace SmartHomeHub.Modes;

public interface IHomeMode
{
    string Name { get; }
    IEnumerable<ICommand> BuildCommands(SmartHomeContext context);
}

