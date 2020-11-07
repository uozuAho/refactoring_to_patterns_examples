using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal interface INode
    {
        string Text { get; set; }

        string ToPlainTextString();
        string ToHtml();
        void CollectInto(List<INode> nodes, string filter);
        void CollectInto(List<INode> nodes, Type nodeType);
        void Accept(NodeVisitor visitor);
    }
}
