using System;
using System.Collections.Generic;

namespace replace_embellishment_with_decorator.initial_state_two
{
    internal interface INode
    {
        string ToPlainTextString();
        string ToHtml();
        void CollectInto(List<INode> nodes, string filter);
        void CollectInto(List<INode> nodes, Type nodeType);
        void Accept(NodeVisitor visitor);
    }
}
