using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeDemo
{
    public abstract class FileSystemItem    //Component
    {
        public abstract long Size();
        //public abstract void Add(FileSystemItem item);
    }

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
    }       //Composite
    public class File : FileSystemItem      //Leaf
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
    }

}
