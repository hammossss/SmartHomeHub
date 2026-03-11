using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Commands;

public interface ICommand
{
    string Description { get; }
    void Execute();
}

