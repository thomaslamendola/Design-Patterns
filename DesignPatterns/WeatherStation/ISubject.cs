using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.WeatherStation
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
        void NotifyObservers(object arg);
        void SetChanged();
    }
}
