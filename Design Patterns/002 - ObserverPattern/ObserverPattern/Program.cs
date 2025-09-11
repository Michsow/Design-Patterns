using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.SetMeasurements(30, 90, 29.2f); 
        }
    }
}