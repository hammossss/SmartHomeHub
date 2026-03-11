using SmartHomeHub.Devices;
using SmartHomeHub.Observers;
using SmartHomeHub.SmartHome;
using SmartHomeHub.Modes;


var hub = new SmartHomeHub.SmartHome.SmartHomeHub(
    new Lamp("Living room lamp"),
    new Thermostat("Hall thermostat", 21),
    new DoorLock("Front door")
);


// Observer
hub.AttachObserverToAll(new DashboardObserver());
hub.AttachObserverToAll(new LoggerObserver());

// Strategy (Mode)
hub.ActivateMode(new NightMode());

Console.WriteLine();
Console.WriteLine("Status after Night Mode:");
hub.PrintStatus();

Console.WriteLine();
hub.ActivateMode(new PartyMode());

Console.WriteLine();
Console.WriteLine("Status after Party Mode:");
hub.PrintStatus();
