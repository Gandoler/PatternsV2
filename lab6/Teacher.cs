namespace lab6;

public class Teacher : ISubject
{
    private List<IObserver> _observers = new();
    public string Name { get; }
    public bool ProgressCreatedThisWeek { get; private set; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(this);
    }

    public void CreateProgress()
    {
        ProgressCreatedThisWeek = true;
        Console.WriteLine($"{Name} создал успеваемость.");
    }

    public void CheckDeadline()
    {
        if (!ProgressCreatedThisWeek)
        {
            Console.WriteLine($"{Name} не создал успеваемость — уведомление деканату.");
            Notify();
        }
        ProgressCreatedThisWeek = false; // сброс на новую неделю
    }
}
