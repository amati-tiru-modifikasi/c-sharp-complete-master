using System.Collections.Generic;

namespace ObserverPattern
{
    public class Observable<T>
    {
        private T subject;
        private List<Observer<T>> _observers = new List<Observer<T>>();

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

        public void Subscribe(Observer<T> observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(Observer<T> observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers(T oldValue, T newValue)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(oldValue, newValue);
            }
        }
    }
}