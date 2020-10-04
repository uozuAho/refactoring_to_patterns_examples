namespace move_creation_to_factory.refactored
{
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
}