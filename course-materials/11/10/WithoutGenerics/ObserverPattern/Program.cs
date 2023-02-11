using System;
using System.Timers;

namespace ObserverPattern
{
    class Program
    {
        private static Observable observable = new Observable(5);
        static void Main(string[] args)
        {
            CreateObserversAndSubscribe();
            var timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            observable.Subject = 10;
            // you have to cast
            int value = (int)observable.Subject;
            while (true)
            {
                timer.Start();
            }
        }

        private static void CreateObserversAndSubscribe()
        {
            observable.Subscribe(new Observer("Observer 1"));
            observable.Subscribe(new Observer("Observer 2"));
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            observable.Subject = new Random().Next(0, 100);
        }
    }
}
