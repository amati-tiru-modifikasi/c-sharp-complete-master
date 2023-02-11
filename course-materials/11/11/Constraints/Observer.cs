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

        public void Notify<T>(T oldValue, T newValue) where T : struct, IComparable<T>
        {
            if (oldValue.CompareTo(newValue) != 0)
            {
                Console.WriteLine($"{name} : value changed from {oldValue} to {newValue}");
            }
        }
    }
}