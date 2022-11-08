namespace ChainSimple
{
    public class TrimHandler : Handler<string>
    {
        public override string Handle(string request)
        {
            request = request.Trim();
            return CallNext(request);
        }

    }
}