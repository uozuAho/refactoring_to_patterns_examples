using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.initial_state
{
    internal abstract class AbstractNode : INode
    {
        public readonly int BeginPosition;
        public readonly int EndPosition;

        public Tag Parent { get; set; }

        protected string TextBuffer;

        protected AbstractNode(int beginPosition, int endPosition)
        {
            BeginPosition = beginPosition;
            EndPosition = endPosition;
        }

        public abstract string ToPlainTextString();
        public abstract string ToHtml();

        public void CollectInto(List<INode> nodes, string filter)
        {
        }

        public void CollectInto(List<INode> nodes, Type nodeType)
        {
        }

        public void Accept(NodeVisitor visitor)
        {
        }
    }
}
