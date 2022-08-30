using BasicVisitorSample.FileSystem;

namespace BasicVisitorSample.Visitors
{
    public interface IFileSystemVisitor
    {
        public void Visit(Directory directory);
        public void Visit(File file);
    }

    public class FileSystemVisitor : IFileSystemVisitor
    {
        public virtual void Visit(Directory directory)
        {
        }
        public virtual void Visit(File file)
        {
        }
    }
}