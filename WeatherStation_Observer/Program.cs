using WeatherStation_Observer.Displays;

namespace WeatherStation_Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var currentTemperatureDisplay = new CurrentTemperatureDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            currentConditionsDisplay.Display();
            currentTemperatureDisplay.Display();

            weatherData.SetTemperature(15, 12, 517);
            currentConditionsDisplay.Display();
            currentTemperatureDisplay.Display();
            heatIndexDisplay.Display();
        }
    }
}