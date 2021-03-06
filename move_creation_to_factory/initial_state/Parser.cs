﻿namespace move_creation_to_factory.initial_state
{
    internal class Parser
    {
        public bool ShouldDecodeNodes { get; set; }
        public bool ShouldRemoveEscapeCharacters { get; set; }

        public Node Parse(string url)
        {
            string content = "text loaded from url";

            return new StringParser(this).Find(content, 0, content.Length);
        }
    }
}