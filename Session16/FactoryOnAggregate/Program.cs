using FactoryOnAggregate.Model;

namespace FactoryOnAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var forum = FindForum();
            var discussion = forum.StartDiscussion("", 0, "");
        }

        private static Forum FindForum()
        {
            throw new NotImplementedException();
        }
    }
}
