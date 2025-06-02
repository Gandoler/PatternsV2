namespace Lab3;

class Passenger : AirplaneUnit
{
    public enum PassengerClass { First, Business, Economy }

    public string Name { get; }
    public PassengerClass Class { get; }
    public double BaggageWeight { get; private set; }
    public double FreeLimit =>
        Class switch {
            PassengerClass.First => double.MaxValue,
            PassengerClass.Business => 35,
            PassengerClass.Economy => 20,
            _ => 0
        };

    public bool BaggageRemoved { get; private set; }

    public Passenger(string name, PassengerClass pClass, double baggageWeight)
    {
        Name = name;
        Class = pClass;
        BaggageWeight = baggageWeight;
    }

    public override double GetBaggageWeight() => BaggageRemoved ? 0 : BaggageWeight;

    public override void RemoveExcessBaggage(double excess)
    {
        if (Class == PassengerClass.Economy && !BaggageRemoved && excess > 0)
        {
            BaggageRemoved = true;
            Console.WriteLine($"[!] Багаж пассажира {Name} (эконом) снят с рейса ({BaggageWeight} кг)");
        }
    }

    public override void PrintLoadingMap()
    {
        Console.WriteLine($"{Class} | {Name} | Багаж: {(BaggageRemoved ? "Снят" : $"{BaggageWeight} кг")}");
    }
}