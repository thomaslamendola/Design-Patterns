using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.WeatherStation
{
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
            if(o is WeatherData)
            {
                WeatherData weatherData = (WeatherData)o;
                _lastPressure = _currentPressure;
                _currentPressure = weatherData.GetPressure();
                if (_currentPressure > _lastPressure)
                {
                    _status = "Getting better";
                    Display();
                }
                else if (_currentPressure < _lastPressure)
                {
                    _status = "Worsening";
                    Display();
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Pressure has changed! New value: {_currentPressure} ({_status})");
        }
    }
}
