using System;

namespace PrototypeSample.WorkflowDesigner
{
    public interface ICloneable<out T>
    {
        T Clone();
    }

    public interface IEditorElement : ICloneable<IEditorElement>
    {
    }
    public class Rectangle : IEditorElement
    {
        private long something;
        public long Width { get; private set; }
        public long Height { get; private set; }
        public Rectangle(long width, long height)
        {
            Width = width;
            Height = height;
        }
        public IEditorElement Clone()
        {
            //return new Rectangle(this.Width, this.Height)
            //{
            //    something = something
            //};
            return (IEditorElement)this.MemberwiseClone();
        }
    }
}