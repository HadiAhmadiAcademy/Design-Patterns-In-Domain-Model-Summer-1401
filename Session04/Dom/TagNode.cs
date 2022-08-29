using System;
using System.Collections.Generic;
using System.Text;

namespace Dom
{
    public class TagNode
    {
        private readonly StringBuilder _attributes;
        private readonly IList<TagNode> _children = new List<TagNode>();
        private readonly string _name;
        private string _value = string.Empty;

        public TagNode(string name)
        {
            this._name = name;
            this._attributes = new StringBuilder();
        }

        public void Add(TagNode tagNode)
        {
            this._children.Add(tagNode);
        }

        public void AddAttribute(string attribute, string value)
        {
            this._attributes.Append(" ");
            this._attributes.Append(attribute);
            this._attributes.Append("='");
            this._attributes.Append(value);
            this._attributes.Append("'");
        }
        public void AddValue(string value)
        {
            this._value = value;
        }
        private StringBuilder Render(StringBuilder resultBuilder)
        {
            resultBuilder.Append($"<{this._name} {this._attributes}>");
            foreach (var tagNode in _children)
                tagNode.Render(resultBuilder);

            resultBuilder.Append($"{this._value}");
            resultBuilder.Append($"</{this._name}>");
            return resultBuilder;
        }
        public string Render()
        {
            return Render(new StringBuilder()).ToString();
        }
    }
}
