using BasicVisitorSample.Visitors;

namespace BasicVisitorSample.FileSystem
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public abstract long Size();
        public abstract void Accept(IFileSystemVisitor visitor);
    }
}
