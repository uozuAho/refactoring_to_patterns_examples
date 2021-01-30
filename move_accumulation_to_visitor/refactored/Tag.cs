using System;

namespace move_accumulation_to_visitor.refactored
{
    public class Tag : AbstractNode
    {
        public string GetTagName()
        {
            throw new NotImplementedException();
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.VisitTag(this);
        }
    }
}
