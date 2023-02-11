using System;

namespace ObserverPattern
{
    public class Observer
    {
        private string name;

        public Observer(string name)
        {
            this.name = name;
        }

        public void Notify(object oldValue, object newValue)
        {
            Console.WriteLine($"{name} : value changed from {oldValue} to {newValue}");
        } 

    }
}