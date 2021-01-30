namespace move_accumulation_to_visitor.refactored
{
    public class EndTag : Tag
    {
        public override void Accept(INodeVisitor visitor)
        {
            visitor.VisitEndTag(this);
        }
    }
}
