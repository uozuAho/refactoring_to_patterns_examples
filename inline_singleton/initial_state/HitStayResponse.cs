namespace inline_singleton.initial_state
{
    internal class HitStayResponse
    {
        public string ReadFrom(BufferedReader input)
        {
            return "yo";
        }

        public bool ShouldHit()
        {
            return false;
        }
    }
}
