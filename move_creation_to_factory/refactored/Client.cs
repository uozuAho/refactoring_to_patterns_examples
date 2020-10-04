namespace move_creation_to_factory.refactored
{
    internal class Client
    {
        static void NewMain(string[] args)
        {
            var nodeFactory = new NodeFactory(new StringNodeParsingOptions
            {
                ShouldDecodeNodes = true
            });

            var parser = new Parser(nodeFactory);

            var parentNode = parser.Parse("https://www.google.com.au");
        }
    }
}
