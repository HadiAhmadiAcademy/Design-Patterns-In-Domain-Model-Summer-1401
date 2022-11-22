using System;

namespace StatePatternSample
{
    public class Order
    {
        public OrderState State { get; private set; }
        public Order()
        {
            this.State = OrderState.InitialState();
        }
        public void AddItem(OrderItem item)
        {
            //this.State.GoToNextState(this);

            //this.State = this.State.NextState();

            if (this.State.CanModify())
            {
                //............
            }
        }
        public void Cancel()
        {
            //if (this.state.CanCancel())
            //      this.state = new Cancelled();
            this.State = OrderStateFactory.Create<Cancelled>();
        }
    }
}
