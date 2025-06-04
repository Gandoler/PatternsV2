namespace Lab3;

class Airplane : AirplaneUnit
{
    private readonly List<AirplaneUnit> units = new();
    private readonly double maxTotalBaggage;

    public Airplane(double maxTotalBaggage) => this.maxTotalBaggage = maxTotalBaggage;

    public override void Add(AirplaneUnit unit) => units.Add(unit);
    public override double GetBaggageWeight() => units.Sum(u => u.GetBaggageWeight());

    public override void CheckOverweight()
    {
        double total = GetBaggageWeight();
        if (total <= maxTotalBaggage)
        {
            Console.WriteLine($"[*] Общая загрузка в норме: {total} кг");
            return;
        }

        double excess = total - maxTotalBaggage;
        Console.WriteLine($"[!] Превышение загрузки: {excess} кг");

        // Снимаем багаж только у эконом-пассажиров
        foreach (var unit in units)
            unit.RemoveExcessBaggage(excess);
    }

    public override void PrintLoadingMap()
    {
        Console.WriteLine("\n=== Карта загрузки самолета ===");
        foreach (var unit in units)
            unit.PrintLoadingMap();
        Console.WriteLine($"Общий вес багажа: {GetBaggageWeight()} кг (макс. {maxTotalBaggage} кг)");
    }
}
