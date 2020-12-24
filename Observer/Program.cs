using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            _ = new CurrentConditionsDisplay(weatherData);
            _ = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(20, 65, 30.4f);
            weatherData.SetMeasurements(22, 70, 29.2f);
            weatherData.SetMeasurements(18, 90, 29.2f);
        }

        public interface ISubject
        {
            void RegisterObserver(IObserver o);
            void RemoveObserver(IObserver o);
            void NotifyObservers();
            void NotifyObservers(object arg);
            void SetChanged();
        }

        public interface IObserver
        {
            void Update(ISubject o, object arg);
        }

        public interface IDisplayElement
        {
            void Display();
        }

        public class WeatherData : ISubject
        {
            private readonly List<IObserver> _observers;

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
                if (_changed)
                {
                    foreach (var observer in _observers)
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

        public class CurrentConditionsDisplay : IObserver, IDisplayElement
        {
            private double _temperature;
            private double _humidity;

            private readonly ISubject _weatherData;

            public CurrentConditionsDisplay(ISubject weatherData)
            {
                _weatherData = weatherData;
                _weatherData.RegisterObserver(this);
            }

            public void Update(ISubject o, object arg)
            {
                // if arg is null we are using pull, otherwise it is a push...

                if (o is WeatherData weatherData)
                {
                    _temperature = weatherData.GetTemperature();
                    _humidity = weatherData.GetHumidity();
                    Display();
                }
            }

            public void Display()
            {
                Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
            }
        }

        public class ForecastDisplay : IObserver, IDisplayElement
        {
            private double _currentPressure = 29.92f;
            private double _lastPressure;
            private string _status;

            public ForecastDisplay(ISubject o)
            {
                o.RegisterObserver(this);
            }

            public void Update(ISubject o, object arg)
            {
                if (o is WeatherData weatherData)
                {
                    _lastPressure = _currentPressure;
                    _currentPressure = weatherData.GetPressure();

                    if (_currentPressure > _lastPressure)
                    {
                        _status = "Getting better";
                    }
                    else if (_currentPressure < _lastPressure)
                    {
                        _status = "Worsening";
                    }
                    else
                    {
                        return;
                    }
                    Display();
                }
            }

            public void Display()
            {
                Console.WriteLine($"Pressure has changed! New value: {_currentPressure} ({_status})");
            }
        }
    }
}
