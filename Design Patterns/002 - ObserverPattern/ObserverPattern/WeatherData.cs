using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private readonly List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        // Notify all observers of updated state
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Add an observer if not already subscribed
        public void RegisterObserver(Observer o)
        {
            if (!observers.Contains(o))
            {
                observers.Add(o);
            }
        }

        // Remove an observer if subscribed
        public void RemoveObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
        }

        // Called when data changes
        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        // Update state and notify observers
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
