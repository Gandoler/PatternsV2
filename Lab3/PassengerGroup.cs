namespace Lab3;

class PassengerGroup : AirplaneUnit
{
    private readonly List<AirplaneUnit> units = new();
    private readonly string groupName;

    public PassengerGroup(string groupName) => this.groupName = groupName;

    public override void Add(AirplaneUnit unit) => units.Add(unit);
    public override void Remove(AirplaneUnit unit) => units.Remove(unit);

    public override double GetBaggageWeight() =>
        units.Sum(u => u.GetBaggageWeight());

    public override void RemoveExcessBaggage(double excess)
    {
        foreach (var unit in units.OfType<Passenger>())
        {
            if (excess <= 0) break;
            if (unit is Passenger p)
            {
                double before = p.GetBaggageWeight();
                p.RemoveExcessBaggage(excess);
                excess -= before;
            }
        }
    }

    public override void PrintLoadingMap()
    {
        Console.WriteLine($"== {groupName} ==");
        foreach (var unit in units)
            unit.PrintLoadingMap();
    }
}
