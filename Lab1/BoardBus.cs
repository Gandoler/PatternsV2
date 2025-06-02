namespace Lab1;

public class BoardBus : ITransportFactory
{
    private BusDriver? _driver;
    private readonly List<Passenger> _passengers = new();
    private const int Capacity = 30;

    public void BoardDriver()
    {
        if (_driver != null)
        {
            throw new InvalidOperationException("A driver is already onboard.");
        }
        else
        {
            _driver = BusDriver.GetInstance("Serejka");
        }
    }

    public void BoardPassenger()
    {
        Passenger passenger = new($"passanger number {new Random().Next(1,1000)}");
        if (_passengers.Count >= Capacity)
            throw new InvalidOperationException("Bus is full.");
        _passengers.Add(passenger);
    }

    public bool IsReadyToDepart()
    {
        return _driver != null && _passengers.Count > 0;
    }
}