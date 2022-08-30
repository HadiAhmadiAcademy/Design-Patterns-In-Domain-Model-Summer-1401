using BasicVisitorSample.FileSystem;

namespace BasicVisitorSample.Visitors
{
    public class LargestFileVisitor : FileSystemVisitor
    {
        private long _maxSize = 0;
        public override void Visit(File file)
        {
            if (this._maxSize < file.Size())
                this._maxSize = file.Size();
        }

        public long GetMaximumSize() => _maxSize;
    }
}