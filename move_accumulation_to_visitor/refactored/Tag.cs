using System;

namespace move_accumulation_to_visitor.refactored
{
    public class Tag : Node
    {
        public string GetTagName()
        {
            throw new NotImplementedException();
        }

        public virtual void Accept(TextExtractor textExtractor)
        {
            textExtractor.VisitTag(this);
        }
    }
}
