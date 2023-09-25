using WeatherStation_Observer.Interfaces;

namespace WeatherStation_Observer
{
    internal class WeatherData : Subject
    {
           /* Геттеры можно было бы не делать и передавать наблюдателю полный набор данных.
            * Но удобнее когда наблюдатель сам (в своем методе Update) запрашивает только то, что ему нужно/
            * Сеттеры в этой задаче нужны, чтобы имитировать работу метеостанции. */
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        private List<Observer> _observersList;

        public WeatherData()
        {
            _observersList = new List<Observer>();
        }

           /* Метеоданные должны передаваться из метеостанции, но т.к. ее нет, будем задавать данные сами. */
        public void SetTemperature(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            MeasurementsChanged();
        }

           /* Метод вызывается, если метеоданные изменились. */
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

           /* Реализуем интерфейс "Субъекта"*/
        public void RegisterObserver(Observer observer)
        {
            _observersList.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observersList.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in _observersList)
            {
               observer.Update();
            }
        }
    }
}
