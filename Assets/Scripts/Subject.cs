using System.Collections.Generic;

public class Subject {

    // A list with observers that are waiting for something to happen.
    private List<Observer> observers = new List<Observer>();

    // Send notification if something has happened.
    public void Notify()
    {
        foreach (Observer element in observers)
        {
            element.OnNotify();
        }
    }

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }
}
