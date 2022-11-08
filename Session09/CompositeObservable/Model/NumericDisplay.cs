using System;
using System.Diagnostics;

namespace CompositeObservable.Model
{
    public class NumericDisplay : Framework.IObserver<Sensor>
    {
        public void Notify(Sensor sensor)
        {
            Console.WriteLine($"{sensor.Name} : " + sensor.CurrentTemperature);
        }
    }

}