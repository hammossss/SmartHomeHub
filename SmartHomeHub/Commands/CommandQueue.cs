using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeHub.Commands;

public sealed class CommandQueue
{
    private readonly Queue<ICommand> _queue = new();

    public void Enqueue(ICommand command) => _queue.Enqueue(command);

    public int Count => _queue.Count;

    public void RunAll()
    {
        while (_queue.Count > 0)
        {
            var cmd = _queue.Dequeue();
            Console.WriteLine($"[COMMAND] {cmd.Description}");
            cmd.Execute();
        }
    }
}

