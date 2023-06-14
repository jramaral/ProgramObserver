using ProgramObserver.Interfaces;

namespace ProgramObserver.Observable;

public class Observer : IObserver
{
    private string name;
    
    public Observer(string name)
    {
        this.name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine($"Observer {name} received message: {message}");
    }
}