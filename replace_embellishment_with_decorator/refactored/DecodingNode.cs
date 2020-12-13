using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal class DecodingNode : INode
    {
        private readonly INode _mrDelegate;

        public DecodingNode(int beginPosition, int endPosition)
        {
            _mrDelegate = new StringNode(beginPosition, endPosition);
        }

        public DecodingNode(
            string textBuffer,
            int beginPosition,
            int endPosition)
        {
        }

        public string Text { get; set; }

        public string ToPlainTextString()
        {
            return Translate.Decode(_mrDelegate.ToPlainTextString());
        }

        public string ToHtml()
        {
            return _mrDelegate.ToHtml();
        }

        public void CollectInto(List<INode> nodes, string filter)
        {
            _mrDelegate.CollectInto(nodes, filter);
        }

        public void CollectInto(List<INode> nodes, Type nodeType)
        {
            _mrDelegate.CollectInto(nodes, nodeType);
        }

        public void Accept(NodeVisitor visitor)
        {
            _mrDelegate.Accept(visitor);
        }
    }
}
