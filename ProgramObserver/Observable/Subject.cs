using ProgramObserver.Interfaces;

namespace ProgramObserver.Observable;

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    
    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(message);
        }
    }
}