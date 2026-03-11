using SmartHomeHub.Commands;
using SmartHomeHub.Devices;
using SmartHomeHub.Infrastructure;
using SmartHomeHub.Modes;
using SmartHomeHub.Observers;

namespace SmartHomeHub.SmartHome;

public sealed class SmartHomeHub
{
    private readonly CommandQueue _queue = new();
    private readonly SmartHomeContext _context;

    public Lamp LivingRoomLamp => _context.LivingRoomLamp;
    public Thermostat HallThermostat => _context.HallThermostat;
    public DoorLock FrontDoor => _context.FrontDoor;

    public SmartHomeHub(Lamp livingRoomLamp, Thermostat hallThermostat, DoorLock frontDoor)
    {
        _context = new SmartHomeContext(livingRoomLamp, hallThermostat, frontDoor);
    }

    public void AttachObserverToAll(IDeviceObserver observer)
    {
        LivingRoomLamp.Attach(observer);
        HallThermostat.Attach(observer);
        FrontDoor.Attach(observer);
    }

    public void Enqueue(ICommand command) => _queue.Enqueue(command);

    public void RunQueue()
    {
        Logger.Instance.Log($"Running command queue ({_queue.Count} commands).");
        _queue.RunAll();
    }

    public void ActivateMode(IHomeMode mode)
    {
        Logger.Instance.Log($"Activating mode: {mode.Name}");

        foreach (var cmd in mode.BuildCommands(_context))
            _queue.Enqueue(cmd);

        RunQueue();
    }

    public void PrintStatus()
    {
        Console.WriteLine(LivingRoomLamp.GetStatus());
        Console.WriteLine(HallThermostat.GetStatus());
        Console.WriteLine(FrontDoor.GetStatus());
    }
}

