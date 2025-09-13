using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this); 
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            // Set the correct fields with the relevant parameters
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (humidity < 50 && temperature > 30)
            {
                Console.WriteLine("Forecast: It's going to be sunny and hot today!");
            }
            else if (humidity >= 50 && temperature > 30)
            {
                Console.WriteLine("Forecast: It's going to be humid and hot today!");
            }
            else if (humidity < 50 && temperature <= 30)
            {
                Console.WriteLine("Forecast: It's going to be cool and dry today!");
            }
            else
            {
                Console.WriteLine("Forecast: It's going to be cool and humid today!");
            }

        }
    }
}
