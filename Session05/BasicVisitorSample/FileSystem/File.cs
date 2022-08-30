using BasicVisitorSample.Visitors;

namespace BasicVisitorSample.FileSystem
{
    public class File : FileSystemItem
    {
        private readonly long _size;
        public File(long size)
        {
            _size = size;
        }
        public override long Size()
        {
            return _size;
        }

        public override void Accept(IFileSystemVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}