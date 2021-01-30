namespace move_accumulation_to_visitor.refactored
{
    public class StringNode : Node
    {
        public string GetText()
        {
            return "";
        }

        public void Accept(TextExtractor textExtractor)
        {
            textExtractor.VisitStringNode(this);
        }
    }
}
