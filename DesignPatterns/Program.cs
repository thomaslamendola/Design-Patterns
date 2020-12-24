using DesignPatterns.RPG;
using DesignPatterns.WeatherStation;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            #region Observable

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(20, 65, 30.4f);
            weatherData.SetMeasurements(22, 70, 29.2f);
            weatherData.SetMeasurements(18, 90, 29.2f);

            #endregion

            Console.ReadLine();
        }
    }
}
