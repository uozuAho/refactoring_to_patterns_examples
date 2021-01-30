namespace move_accumulation_to_visitor.refactored
{
    public interface INodeVisitor
    {
        void VisitStringNode(StringNode stringNode);
        void VisitLinkTag(LinkTag link);
        void VisitEndTag(EndTag endTag);
        void VisitTag(Tag tag);
    }
}
