namespace move_creation_to_factory.initial_state
{
    class Client
    {
        static void Main(string[] args)
        {
            var parser = new Parser
            {
                ShouldDecodeNodes = true,
            };

            var parentNode = parser.Parse("https://www.google.com.au");
        }
    }
}
