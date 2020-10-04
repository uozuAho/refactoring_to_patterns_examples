namespace move_creation_to_factory.refactored
{
    internal class Parser
    {
        public NodeFactory NodeFactory { get; }

        public Parser(NodeFactory nodeFactory)
        {
            NodeFactory = nodeFactory;
        }

        public Node Parse(string url)
        {
            string content = "text loaded from url";

            return new StringParser(this).FindString(content, 0, content.Length);
        }
    }
}