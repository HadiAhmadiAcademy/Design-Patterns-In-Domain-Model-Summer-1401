using System;
using System.Diagnostics;

namespace SensorObserverSample.Model
{
    public class NumericDisplay : Framework.IObserver<int>
    {
        public void Notify(int value)
        {
            Console.WriteLine(value);
        }
    }

    public class Gauge : Framework.IObserver<int>
    {
        public void Notify(int value)
        {
            Debug.WriteLine($"------------ {value} ---------------");
        }
    }
}