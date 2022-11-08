using System;
using System.Collections.Generic;
using CompositeObservable.Model;

namespace CompositeObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var batch = GetSensor();

            var sensors = new List<Sensor>();


            var display = new NumericDisplay();
            //batch.Subscribe(display);

            Console.ReadLine();
        }

        private static SensorBatch GetSensor()
        {
            var sensor1 = new Sensor("Sensor 1");
            var sensor2 = new Sensor("Sensor 2");

            var batch = new SensorBatch();
            sensor1.Subscribe(batch);
            sensor2.Subscribe(batch);

            sensor1.StartDetecting();
            sensor2.StartDetecting();
            return batch;
        }
    }
}
