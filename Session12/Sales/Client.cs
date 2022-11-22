namespace Sales
{
    public class Client
    {
        public void ReturnOrder(long orderId)
        {
            //var order = GetOrder(orderId);
            var returnOrder = CreateReturnOrderFor();

            ReturnProcess returnProcess = GetAppropriateReturnProcess(returnOrder);
            returnProcess.Return(returnOrder);
        }

        private ReturnOrder CreateReturnOrderFor()
        {
            throw new System.NotImplementedException();
        }
        private static ReturnProcess GetAppropriateReturnProcess(ReturnOrder order)
        {
            if (order.CustomerType == CustomerType.Gold)
                return new FullRefundProcess();
            else return new RefundWithPenalty();
        }
    }
}