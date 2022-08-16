namespace Reporting.Builder
{
    public class HtmlReportBuilder : IReportBuilder
    {
        public void AddTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public void AddParagraph(string content)
        {
            throw new System.NotImplementedException();
        }

        public void Footer(string text)
        {
            throw new System.NotImplementedException();
        }

        public Document Build()
        {
            return new HtmlDocument();
        }
    }
}