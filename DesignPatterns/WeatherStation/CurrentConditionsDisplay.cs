using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.WeatherStation
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;

        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(ISubject o, object arg)
        {
            // if arg is null we are using pull, otherwise it is a push...
            if(o is WeatherData)
            {
                WeatherData weatherData = (WeatherData)o;
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
}
