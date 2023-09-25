using WeatherStation_Observer.Interfaces;

namespace WeatherStation_Observer.Displays
{
    internal class CurrentConditionsDisplay : DisplayElement
    {
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }
        
        public void Display()
        {
            Console.WriteLine($"В настоящее время T = {_weatherData.Temperature}, RH = {_weatherData.Humidity}, P = {_weatherData.Pressure}.");
        }
    }
}
