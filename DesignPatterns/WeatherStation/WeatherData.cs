using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;

        private double _temperature;
        private double _humidity;
        private double _pressure;

        private bool _changed;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void MeasurementChanged()
        {
            SetChanged();
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementChanged();
        }

        public double GetTemperature()
        {
            return _temperature;
        }

        public double GetHumidity()
        {
            return _humidity;
        }

        public double GetPressure()
        {
            return _pressure;
        }

        public void NotifyObservers(object arg)
        {
            if(_changed)
            {
                foreach(var observer in _observers)
                {
                    observer.Update(this, arg);
                }
                _changed = false;
            }
        }

        public void NotifyObservers()
        {
            NotifyObservers(null);
        }

        public void SetChanged()
        {
            _changed = true;
        }
    }
}
