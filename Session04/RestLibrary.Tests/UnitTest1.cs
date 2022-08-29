using System;
using Xunit;

namespace RestLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = HttpRequestFactory
                .NewRequest()
                .Put()
                .WithBody("")
                .Url("http://localhost")
                .Build();
        }
    }
}
