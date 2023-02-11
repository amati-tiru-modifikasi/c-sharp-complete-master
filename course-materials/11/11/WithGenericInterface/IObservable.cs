using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IObservable<T>
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
    }
}