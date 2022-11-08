namespace StatePatternSample
{
    public abstract class OrderState
    {
        public static OrderState InitialState()
        {
            return new Draft();
        }
        public abstract bool CanModify();
    }
    public class Confirmed : OrderState
    {
        public override bool CanModify() => false;
    }
    public class Draft : OrderState             //2
    {
        public override bool CanModify() => true;
       
    }
    public class Cancelled : OrderState         //3
    {
        public override bool CanModify() => false;
    }
}