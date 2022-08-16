using System;
using System.Data.Common;
using System.Data.SqlClient;
using Reporting.Builder;
using Reporting.Directors;
using Xunit;

namespace Reporting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = new HtmlReportBuilder();
            var reportGenerator = new ProfitReportGenerator(builder);
            reportGenerator.Parse("...");
            var report = builder.Build();

            //------------

            //var builder = new HtmlReportBuilder();
            //builder.AddTitle("xxxxxxxx");
            //builder.AddParagraph("aaaaaaa");
            //builder.AddParagraph("aaaaaaa");
            //builder.AddParagraph("aaaaaaa");
            //var report = builder.Build();

            //------------
        }
    }
}
