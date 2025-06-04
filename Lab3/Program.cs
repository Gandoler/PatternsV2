using Lab3;

class Program
{
    static void Main()
    {
        var airplane = new Airplane(maxTotalBaggage: 5000);

        // Добавляем экипаж
        airplane.Add(new Pilot());
        airplane.Add(new Pilot());

        for (int i = 0; i < 6; i++)
            airplane.Add(new Stewardess());

        // Первый класс
        var firstClass = new PassengerGroup("Первый класс");
        for (int i = 1; i <= 10; i++)
            firstClass.Add(new Passenger($"VIP-{i}", Passenger.PassengerClass.First, 50));
        airplane.Add(firstClass);

        // Бизнес
        var businessClass = new PassengerGroup("Бизнес класс");
        for (int i = 1; i <= 20; i++)
            businessClass.Add(new Passenger($"Biz-{i}", Passenger.PassengerClass.Business, 40));
        airplane.Add(businessClass);

        // Эконом
        var economyClass = new PassengerGroup("Эконом класс");
        for (int i = 1; i <= 150; i++)
            economyClass.Add(new Passenger($"Eco-{i}", Passenger.PassengerClass.Economy, 25 + (i % 10)));
        airplane.Add(economyClass);

        // Проверка перегруза и карта
        airplane.CheckOverweight();
        airplane.PrintLoadingMap();
    }
}