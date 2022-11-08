using System;
using CompositeObservable.Framework;

namespace CompositeObservable.Model
{
    public class SensorBatch : SimpleObservable<Sensor>, Framework.IObserver<Sensor>
    {
        public void Notify(Sensor sensor)
        {
            NotifyAllObservers(sensor);
        }
    }
}