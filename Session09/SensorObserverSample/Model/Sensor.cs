using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SensorObserverSample.Framework;

namespace SensorObserverSample.Model
{
    public class Sensor : SimpleObservable<int>
    {
        public int CurrentTemperature { get; private set; }
        public void StartDetecting()
        {
            Task.Factory.StartNew(() =>
            {
                var random = new Random();
                while (true)
                {
                    CurrentTemperature = random.Next(-10, 50);
                    NotifyAllObservers(CurrentTemperature);
                    Thread.Sleep(1000);
                }
            });
        }
    }
}