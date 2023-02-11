using System;
using System.Timers;

namespace ObserverPattern
{
    class Program
    {
        private static Observable<bool> observable = new Observable<bool>(true);
        static void Main(string[] args)
        {
            CreateObserversAndSubscribe();
            var timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
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
            observable.Subject = Convert.ToBoolean(new Random().Next(0, 2));
        }
    }
}
