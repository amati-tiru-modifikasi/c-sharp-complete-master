using System.Collections.Generic;

namespace ObserverPattern
{
    public class Observable<T>
    {
        private T subject;
        private List<Observer> _observers = new List<Observer>();

        public T Subject
        {
            get
            {
                return subject;
            }
            set
            {
                T oldValue = subject;
                subject = value;
                NotifyObservers(oldValue, subject);
            }
        }

        public Observable(T value)
        {
            subject = value;
        }

        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers(T oldValue, T newValue)
        {
            foreach (var observer in _observers)
            {
                observer.Notify<T>(oldValue, newValue);
            }
        }
    }
}