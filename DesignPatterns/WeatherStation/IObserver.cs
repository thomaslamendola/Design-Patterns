namespace DesignPatterns.WeatherStation
{
    public interface IObserver
    {
        void Update(ISubject o, object arg);
    }
}
