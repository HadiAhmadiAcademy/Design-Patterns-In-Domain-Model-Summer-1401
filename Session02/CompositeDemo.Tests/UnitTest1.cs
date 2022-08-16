using System;
using Xunit;

namespace CompositeDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var file1 = new File(10);
            var file2 = new File(20);
            var file3 = new File(30);
            var directory1 = new Directory(file1, file2);
            var root = new Directory(directory1, file3);

            var size = root.Size();

        }
      
    }
}
