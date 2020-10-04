namespace move_creation_to_factory.refactored
{
    internal class StringParser
    {
        private readonly NodeFactory _nodeFactory;

        public StringParser(NodeFactory nodeFactory)
        {
            _nodeFactory = nodeFactory;
        }

        public Node FindString(string textBuffer, int textBegin, int textEnd)
        {
            return _nodeFactory.CreateStringNode(textBuffer, textBegin, textEnd);
        }
    }
}