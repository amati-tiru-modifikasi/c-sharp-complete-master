using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IObservable<T> where T : struct, IComparable<T>
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
    }
}