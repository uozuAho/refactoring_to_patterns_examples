namespace inline_singleton.initial_state
{
    internal class Console
    {
        private static HitStayResponse _hitStayResponse = new HitStayResponse();

        private Console() {}

        public static HitStayResponse ObtainHitStayResponse(BufferedReader input)
        {
            _hitStayResponse.ReadFrom(input);
            return _hitStayResponse;
        }

        public static void SetPlayerResponse(HitStayResponse newHitStayResponse)
        {
            _hitStayResponse = newHitStayResponse;
        }
    }
}
