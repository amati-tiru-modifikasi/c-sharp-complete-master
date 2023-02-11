using System.Collections.Generic;

namespace ObserverPattern
{
    public class Observable
    {
        private object subject;
        private List<Observer> _observers = new List<Observer>();

        public object Subject
        {
            get
            {
                return subject;
            }
            set
            {
                object oldValue = subject;
                subject = value;
                NotifyObservers(oldValue, subject);
            }
        }

        public Observable(object value)
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

        private void NotifyObservers(object oldValue, object newValue)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(oldValue, newValue);
            }
        }
    }
}