using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal abstract class AbstractNode
    {
        public Tag Parent { get; set; }
        public readonly int BeginPosition;
        public readonly int EndPosition;

        protected AbstractNode(int beginPosition, int endPosition)
        {
            BeginPosition = beginPosition;
            EndPosition = endPosition;
        }

        public abstract string ToPlainTextString();
        public abstract string ToHtml();

        public void CollectInto(List<Node> nodes, string filter)
        {
        }

        public void CollectInto(List<Node> nodes, Type nodeType)
        {
        }

        public void Accept(NodeVisitor visitor)
        {
        }
    }
}
