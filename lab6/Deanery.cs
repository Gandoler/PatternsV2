namespace lab6;

public class Deanery : IObserver, ISubject
{
    private List<IObserver> _observers = new();
    private Teacher _lastFaultyTeacher;

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(this);
    }

    public void Update(ISubject subject)
    {
        if (subject is Teacher teacher)
        {
            Console.WriteLine($"Деканат: преподаватель {teacher.Name} не сдал отчёт.");
            _lastFaultyTeacher = teacher;
            Notify(); // Уведомить кафедру
        }
    }

    public Teacher GetLastFaultyTeacher() => _lastFaultyTeacher;
}