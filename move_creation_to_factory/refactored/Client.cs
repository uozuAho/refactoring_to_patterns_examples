namespace move_creation_to_factory.refactored
{
    internal class Client
    {
        static void NewMain(string[] args)
        {
            var parser = new Parser(new NodeFactory(new StringNodeParsingOption
            {
                ShouldDecodeNodes = true
            }));

            var parentNode = parser.Parse("https://www.google.com.au");
        }
    }
}
