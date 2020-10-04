namespace move_creation_to_factory.refactored
{
    internal class Client
    {
        static void NewMain(string[] args)
        {
            var parser = new Parser
            {
                ShouldDecodeNodes = true,
                ShouldRemoveEscapeCharacters = true
            };

            var parentNode = parser.parse("https://www.google.com.au");
        }
    }
}
