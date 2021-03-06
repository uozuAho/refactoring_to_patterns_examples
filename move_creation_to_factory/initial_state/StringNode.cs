﻿namespace move_creation_to_factory.initial_state
{
    internal class StringNode : Node
    {
        public StringNode(string textBuffer, int textBegin, int textEnd)
        {

        }

        public static Node CreateStringNode(
            string textBuffer, int textBegin, int textEnd, bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }
}