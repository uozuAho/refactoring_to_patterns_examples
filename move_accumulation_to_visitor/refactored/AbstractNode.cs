namespace move_accumulation_to_visitor.refactored
{
    public abstract class AbstractNode : INode
    {
        public abstract void Accept(TextExtractor textExtractor);
    }
}
