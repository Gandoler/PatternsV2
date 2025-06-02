namespace Lab3;

class Stewardess : AirplaneUnit
{
    public override double GetBaggageWeight() => 0;
    public override void PrintLoadingMap()
    {
       
        Console.WriteLine("Стюардесса | Багаж: 0 кг");
    }
    public override void RemoveExcessBaggage(double excess)
    {
        // Стюардесса не имеет багажа — ничего не делаем
    }
}