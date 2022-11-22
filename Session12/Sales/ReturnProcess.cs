namespace Sales
{
    public abstract class ReturnProcess
    {
        public void Return(ReturnOrder order)
        {
            var returnTransaction = CreateReturnTransactionFor(order);
            var refund = CalculateRefundOfOrder(order);
            AddItemsToStock(order, returnTransaction);
            //AfterAddingItemsToStock();                //Hook
            PayRefundToCustomer(refund);
        }

        protected virtual Transaction CreateReturnTransactionFor(ReturnOrder order)
        {
            return new Transaction()
            {
                ProductId = order.ProductId,
                Quantity = order.Quantity
            };
        }
        protected abstract decimal CalculateRefundOfOrder(ReturnOrder order);
        protected long AddItemsToStock(ReturnOrder order, Transaction transaction)
        {
            return 0;
        }
        protected long PayRefundToCustomer(decimal refund)
        {
            return 0;
        }
    }

    public class FullRefundProcess : ReturnProcess
    {
        protected override decimal CalculateRefundOfOrder(ReturnOrder order)
        {
            return order.PricePaid + order.PostageCost;
        }
    }
    public class RefundWithPenalty : ReturnProcess
    {
        protected override decimal CalculateRefundOfOrder(ReturnOrder order)
        {
            return (order.PricePaid * 0.8M) + (order.PostageCost * 0.2M);
        }
    }
    public class HalfQuantityRefund : ReturnProcess
    {
        protected override Transaction CreateReturnTransactionFor(ReturnOrder order)
        {
            return new Transaction()
            {
                ProductId = order.ProductId,
                Quantity = order.Quantity / 2,
            };
        }

        protected override decimal CalculateRefundOfOrder(ReturnOrder order)
        {
            return order.PricePaid / 2;
        }
    }
}