namespace move_creation_to_factory.initial_state
{
    class Client
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
}
