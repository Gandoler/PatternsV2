using lab6;

class Program
{
    static void Main()
    {
        Department department = new();
        Deanery deanery = new();
        deanery.Attach(department); // кафедра подписана на деканат

        Teacher teacher1 = new("Иванов");
        Teacher teacher2 = new("Петров");

        teacher1.Attach(deanery);
        teacher2.Attach(deanery);

        // Неделя 1
        teacher1.CreateProgress();
        teacher2.CreateProgress();
        teacher1.CheckDeadline();
        teacher2.CheckDeadline();

        Console.WriteLine();

        // Неделя 2 — Петров не отчитался
        teacher1.CreateProgress();
        // teacher2.CreateProgress(); // забыл

        teacher1.CheckDeadline();
        teacher2.CheckDeadline(); // запускает каскад уведомлений
    }
}