namespace ChainSimple
{
    public class UppercaseHandler : Handler<string>
    {
        public override string Handle(string request)
        {
            request = request.ToUpper();
            return CallNext(request);
        }

    }
}