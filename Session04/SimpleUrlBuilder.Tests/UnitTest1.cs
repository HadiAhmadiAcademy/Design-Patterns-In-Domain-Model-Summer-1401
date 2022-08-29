using System;
using FluentAssertions;
using Xunit;

namespace SimpleUrlBuilder.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var url = new UrlBuilder()
                .WithHost("mySite.com/index")
                .WithQueryString(a => a.WithParam("page", "1").WithParam("take", "20"))
                .WithPort(2020)
                .Build()
                ;

            //url.Should().Be("ftp://google.com/");
        }
    }
}
