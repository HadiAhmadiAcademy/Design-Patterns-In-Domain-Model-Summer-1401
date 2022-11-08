using System;
using System.Diagnostics;

namespace UnsubscribeSample.Model
{
    public class NumericDisplay : Framework.IObserver<int>
    {
        public void Notify(int value)
        {
            Debug.WriteLine(value);
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