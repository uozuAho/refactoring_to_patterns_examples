namespace inline_singleton.refactored
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
