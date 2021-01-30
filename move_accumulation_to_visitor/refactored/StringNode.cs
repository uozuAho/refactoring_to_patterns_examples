namespace move_accumulation_to_visitor.refactored
{
    public class StringNode : AbstractNode
    {
        public string GetText()
        {
            return "";
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.VisitStringNode(this);
        }
    }
}
