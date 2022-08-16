using System;
using System.Collections.Generic;
using System.Text;
using Reporting.Builder;

namespace Reporting.Directors
{
    public class ProfitReportGenerator
    {
        private readonly IReportBuilder _reportBuilder;
        public ProfitReportGenerator(IReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

        public void Parse(string filePath)
        {
            //var content = LoadFile(filePath);

            _reportBuilder.AddTitle("Profit Report");
            //..for....
            _reportBuilder.AddParagraph("....");
            _reportBuilder.AddParagraph("....");
        }
    }
    public class AnotherReport
    {

    }
}
