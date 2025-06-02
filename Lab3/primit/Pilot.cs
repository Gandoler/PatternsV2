namespace Lab3;

class Pilot : AirplaneUnit
{
    public override double GetBaggageWeight() => 0;
    public override void PrintLoadingMap()
    {
        Console.WriteLine("Пилот | Багаж: 0 кг");
    }
    public override void RemoveExcessBaggage(double excess)
    {
        // Пилот не имеет багажа — ничего не делаем
    }
}