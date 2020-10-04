namespace move_creation_to_factory.initial_state
{
    class InitialState
    {
        static void Main(string[] args)
        {
            var parser = new Parser
            {
                ShouldDecodeNodes = true,
                ShouldRemoveEscapeCharacters = true
            };

            var parentNode = parser.parse("https://www.google.com.au");
        }
    }

    public class Parser
    {
        public bool ShouldDecodeNodes { get; set; }
        public bool ShouldRemoveEscapeCharacters { get; set; }

        public Node parse(string url)
        {
            string content = "text loaded from url";

            return new StringParser(this).find(content, 0, content.Length);
        }
    }

    public class StringParser
    {
        private readonly Parser _parser;

        public StringParser(Parser parser)
        {
            _parser = parser;
        }

        public Node find(string textBuffer, int textBegin, int textEnd)
        {
            return StringNode.createStringNode(textBuffer, textBegin, textEnd, _parser.ShouldDecodeNodes);
        }
    }

    public class StringNode : Node
    {
        public StringNode(string textBuffer, int textBegin, int textEnd)
        {

        }

        public static Node createStringNode(
            string textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }

    public class DecodingStringNode : Node
    {
        public DecodingStringNode(StringNode node)
        {

        }
    }

    public class Node
    {

    }
}
