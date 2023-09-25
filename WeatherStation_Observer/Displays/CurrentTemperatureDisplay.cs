namespace WeatherStation_Observer.Displays
{
    internal class CurrentTemperatureDisplay
    {
        private WeatherData _weatherData;

        public CurrentTemperatureDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Display()
        {
            Console.WriteLine($"В настоящее время температура воздуха составляет {_weatherData.Temperature} град.");
        }
    }
}
