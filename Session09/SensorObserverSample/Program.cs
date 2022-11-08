using System;
using SensorObserverSample.Model;

namespace SensorObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new Sensor();

            var gauge = new Gauge();
            var numeric = new NumericDisplay();

            sensor.Subscribe(gauge);
            sensor.Subscribe(numeric);

            sensor.StartDetecting();

            Console.ReadLine();
        }
    }
}
