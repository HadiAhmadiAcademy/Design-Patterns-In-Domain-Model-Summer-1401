using ObserverPullModelSample.Framework;

namespace ObserverPullModelSample.Model
{
    public class BoxDisplay : IObserver<Box>
    {
        public void Notify(Box value)
        {
            var items = value.Items;
            //......
        }
    }
}