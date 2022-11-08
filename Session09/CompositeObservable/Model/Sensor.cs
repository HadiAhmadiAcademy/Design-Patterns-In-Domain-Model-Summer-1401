using System;
using System.Threading;
using System.Threading.Tasks;
using CompositeObservable.Framework;

namespace CompositeObservable.Model
{
    public class Sensor : SimpleObservable<Sensor>
    {
        public string Name { get; private set; }
        public int CurrentTemperature { get; private set; }
        public Sensor(string name)
        {
            Name = name;
        }

        public void StartDetecting()
        {
            Task.Factory.StartNew(() =>
            {
                var random = new Random();
                while (true)
                {
                    CurrentTemperature = random.Next(-10, 50);
                    NotifyAllObservers(this);
                    Thread.Sleep(1000);
                }
            });
        }
    }
}