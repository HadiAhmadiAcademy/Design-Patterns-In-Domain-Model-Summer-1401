using System.Collections.Generic;
using System.Linq;
using BasicVisitorSample.Visitors;

namespace BasicVisitorSample.FileSystem
{
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _children;
        public Directory(params FileSystemItem[] children)
        {
            _children = children.ToList();
        }

        public override long Size()
        {
            long sum = 0;
            foreach (var fileSystemItem in _children)
            {
                sum += fileSystemItem.Size();
            }
            return sum;
        }

        public override void Accept(IFileSystemVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var fileSystemItem in _children)
                fileSystemItem.Accept(visitor);
        }
    }
}