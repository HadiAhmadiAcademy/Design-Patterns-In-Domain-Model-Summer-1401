using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BasicVisitorSample.FileSystem;
using BasicVisitorSample.Visitors;
using Xunit;

namespace BasicVisitorSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var visitor = new CountingVisitor();

            var file1 = new File(1000);
            var file2 = new File(3000);
            var file3 = new File(4000);

            var innerDirectory = new Directory(file2, file3);
            var root = new Directory(file1, innerDirectory);
            root.Accept(visitor);

            var dirCount = visitor.DirectoryCount;
            var fileCount = visitor.FileCount;
        }

    }
}
