namespace Reporting.Builder
{
    public interface IReportBuilder
    {
        void AddTitle(string title);
        void AddParagraph(string content);
        //..........
        //..........
        void Footer(string text);
        Document Build();
    }
}