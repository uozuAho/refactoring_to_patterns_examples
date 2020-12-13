using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal class DecodingNode : INode
    {
        private readonly INode _node;

        public DecodingNode(INode node)
        {
            _node = node;
        }

        public string Text { get; set; }

        public string ToPlainTextString()
        {
            return Translate.Decode(_node.ToPlainTextString());
        }

        public string ToHtml()
        {
            return _node.ToHtml();
        }

        public void CollectInto(List<INode> nodes, string filter)
        {
            _node.CollectInto(nodes, filter);
        }

        public void CollectInto(List<INode> nodes, Type nodeType)
        {
            _node.CollectInto(nodes, nodeType);
        }

        public void Accept(NodeVisitor visitor)
        {
            _node.Accept(visitor);
        }
    }
}
