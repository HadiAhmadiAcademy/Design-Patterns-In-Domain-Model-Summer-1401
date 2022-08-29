namespace Dom
{
    public class XmlDocumentBuilder
    {
        private readonly TagNode _rootNode;
        private TagNode _currentParentNode;
        private TagNode _currentNode;
        public XmlDocumentBuilder(string rootNode)
        {
            _rootNode = new TagNode(rootNode);
            _currentNode = _rootNode;
        }
        public XmlDocumentBuilder AddChild(string name)
        {
            var child = new TagNode(name);
            _currentNode.Add(child);
            _currentParentNode = _currentNode;
            _currentNode = child;
            return this;
        }
        public XmlDocumentBuilder AddSibling(string name)
        {
            var sibling = new TagNode(name);
            _currentParentNode.Add(sibling);
            _currentNode = sibling;
            return this;
        }
        public XmlDocumentBuilder WithAttribute(string key, string value)
        {
            _currentNode.AddAttribute(key, value);
            return this;
        }
        public TagNode Build()
        {
            return _rootNode;
        }
    }
}