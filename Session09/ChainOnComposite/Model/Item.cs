namespace ChainOnComposite.Model
{
    public class Item
    {
        public int Size { get; private set; }
        public Item(int size)
        {
            Size = size;
        }
    }
}