namespace move_creation_to_factory.refactored
{
    internal class NodeFactory
    {
        public Node createStringNode(
            string textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }
}