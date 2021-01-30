namespace move_accumulation_to_visitor.refactored
{
    public interface INode
    {
        void Accept(INodeVisitor visitor);
    }
}
