namespace Lab1;

public abstract class Driver
{
    public string Name { get; }

    protected Driver(string name)
    {
        Name = name;
    }
}

public class BusDriver : Driver
{
    private static BusDriver? _instance;
    private static readonly object _lock = new();

    private BusDriver(string name) : base(name) { }

    public static BusDriver GetInstance(string name)
    {
        lock (_lock)
        {
            return _instance ??= new BusDriver(name);
        }
    }
}

public class TaxiDriver : Driver
{
    private static TaxiDriver? _instance;
    private static readonly object _lock = new();

    private TaxiDriver(string name) : base(name) { }

    public static TaxiDriver GetInstance(string name)
    {
        lock (_lock)
        {
            return _instance ??= new TaxiDriver(name);
        }
    }
}
