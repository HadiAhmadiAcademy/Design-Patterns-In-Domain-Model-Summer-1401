using System.Collections;

namespace SA.Domain.Model.SalesGroups.Enumerators;

public class FirstBreadthEnumerator : IEnumerator<SalesUnit>
{
    private Queue<SalesUnit> _items = new Queue<SalesUnit>();
    private SalesUnit _currentNode;
    private SalesUnit _rootNode;
    public FirstBreadthEnumerator(SalesUnit node)
    {
        _items.Enqueue(node);
        _rootNode = node;
    }
    public bool MoveNext()
    {
        if (!_items.Any()) return false;

        var currentItem = _items.Dequeue();
        foreach (var child in currentItem.Members)
            _items.Enqueue(child);
        _currentNode = currentItem;

        return true;
    }

    public void Reset()
    {
        _items.Clear();
        _items.Enqueue(_rootNode);
        _currentNode = null;
    }

    public SalesUnit Current => _currentNode;
    object IEnumerator.Current => Current;
    public void Dispose()
    {
    }
}