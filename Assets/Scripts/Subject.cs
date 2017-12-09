using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{

    // A list with observers that are waiting for something to happen.
    private List<Observer> observers = new List<Observer>();

    // Send notification if something has happened.
    public void Notify(GameObject subject)
    {
        foreach (Observer observer in observers)
        {
            observer.OnNotify(subject);
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
