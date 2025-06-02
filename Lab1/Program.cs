namespace Lab1;

public class Program
{
    public static void Main()
    {
        var taxiDriver = TaxiDriver.GetInstance("Иван");
        var busDriver = BusDriver.GetInstance("Пётр");

        // Такси
        ITransportFactory taxi = new BoardTaxi();
        taxi.BoardDriver();
        taxi.BoardPassenger();
        taxi.BoardPassenger();

        Console.WriteLine($"Такси готово? {taxi.IsReadyToDepart()}");

        // Автобус
        ITransportFactory bus = new BoardBus();
        bus.BoardDriver();

        for (int i = 0; i < 10; i++)
            bus.BoardPassenger();

        Console.WriteLine($"Автобус готов? {bus.IsReadyToDepart()}");
        
        
    }
}