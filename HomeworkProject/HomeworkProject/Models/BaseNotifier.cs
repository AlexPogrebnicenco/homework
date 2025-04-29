using System.Collections.Generic;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Models
{
    public abstract class BaseNotifier : IOrderNotifier
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public void Subscribe(IObserver obserser)
        {
            if (!_observers.Contains(obserser))
            {
                _observers.Add(obserser);
            }
        }
        public void Unsubscribe(IObserver obserser)
        {
            _observers.Remove(obserser);
        }
        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
