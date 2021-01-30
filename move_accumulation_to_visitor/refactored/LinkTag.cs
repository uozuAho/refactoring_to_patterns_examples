using System;

namespace move_accumulation_to_visitor.refactored
{
    public class LinkTag : Tag
    {
        public string GetLinkText()
        {
            throw new NotImplementedException();
        }

        public string GetLink()
        {
            throw new NotImplementedException();
        }

        public override void Accept(TextExtractor textExtractor)
        {
            textExtractor.VisitLinkTag(this);
        }
    }
}
