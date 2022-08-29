namespace Sales
{
    public class SalesAgent : SalesUnit
    {
        private int _credits;
        public override void PayCommission(int amount)
        {
            this._credits += amount;
        }
    }
}