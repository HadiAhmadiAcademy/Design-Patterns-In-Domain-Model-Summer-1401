using ChainOnComposite.Model;

namespace ChainOnComposite.Visitors
{
    public interface IVisitor
    {
        void Visit(Shelf shelf);
        void Visit(Gallon gallon);
    }
}