namespace move_creation_to_factory.refactored
{
    internal class Parser
    {
        public bool ShouldRemoveEscapeCharacters { get; set; }

        public StringNodeParsingOption StringNodeParsingOption { get; }
            = new StringNodeParsingOption();

        public Node parse(string url)
        {
            string content = "text loaded from url";

            return new StringParser(this).find(content, 0, content.Length);
        }
    }
}