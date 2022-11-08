using System;
using System.Threading;
using UnsubscribeSample.Model;

namespace UnsubscribeSample
{
    public class MyCustomDisposable : IDisposable
    {
        public void Dispose()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Unsubscribe
            //1. sensor.Unsubscribe(numericDisplay);        ( X )
            //2. numericDisplay.Unsubscribe();              ( X )
            //3. Subscription Object                        ( Y )

            var numericDisplay = new NumericDisplay();
            var sensor = new Sensor();
            sensor.StartDetecting();

            // ** Basic Usage
            var subscription = sensor.Subscribe(numericDisplay);
            Thread.Sleep(5000);
            subscription.Unsubscribe();

            // ** With 'Using' Block
            using (sensor.Subscribe(numericDisplay))
            {
                Thread.Sleep(5000);
                //....
                //....
                //....
            }


            Console.ReadLine();
        }
    }
}
