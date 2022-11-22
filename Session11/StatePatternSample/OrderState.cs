namespace StatePatternSample
{
    public abstract class OrderState
    {
        public static OrderState InitialState()
        {
            return OrderStateFactory.Create<Draft>();
        }
        public abstract bool CanModify();
    }
    internal class Confirmed : OrderState
    {
        public override bool CanModify() => false;
    }
    internal class Draft : OrderState
    {
        public override bool CanModify() => true;
    }
    internal class Cancelled : OrderState
    {
        public override bool CanModify() => false;
    }
}