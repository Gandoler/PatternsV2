namespace lab6;

public class Department : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is Deanery deanery)
        {
            var teacher = deanery.GetLastFaultyTeacher();
            Console.WriteLine($"Кафедра: преподаватель {teacher.Name} не сдал успеваемость вовремя.");
        }
    }
}