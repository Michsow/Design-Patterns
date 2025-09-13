using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData); 
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            // Create instances of displays 


            Console.WriteLine("First updates ");
            weatherData.SetMeasurements(28, 65, 30.4f);

            Console.WriteLine("Second updates");
            weatherData.SetMeasurements(29, 70, 29.2f);

            Console.WriteLine("Third updates ");
            weatherData.SetMeasurements(40, 50, 39.2f);

            Console.WriteLine("Unsubscribing ForecastDisplay ");
            weatherData.RemoveObserver(forecastDisplay);

            Console.WriteLine("Fourth updates ");
            weatherData.SetMeasurements(30, 90, 29.2f);

            Console.ReadLine();
        }
    }
}