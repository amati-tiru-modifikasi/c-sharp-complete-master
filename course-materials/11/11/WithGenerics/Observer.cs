using System;

namespace ObserverPattern
{
    public class Observer<T>
    {
        private string name;

        public Observer(string name)
        {
            this.name = name;
        }

        public void Notify(T oldValue, T newValue)
        {
            Console.WriteLine($"{name} : value changed from {oldValue} to {newValue}");
        } 
    }
}