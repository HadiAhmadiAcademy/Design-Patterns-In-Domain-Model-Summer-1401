using BasicVisitorSample.FileSystem;

namespace BasicVisitorSample.Visitors
{
    public class CountingVisitor : FileSystemVisitor
    {
        public int DirectoryCount { get; private set; }
        public int FileCount { get; private set; }
        public override void Visit(Directory directory)
        {
            DirectoryCount++;
        }
        public override void Visit(File file)
        {
            FileCount++;
        }
    }
}