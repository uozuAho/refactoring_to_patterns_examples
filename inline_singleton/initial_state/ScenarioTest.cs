namespace inline_singleton.initial_state
{
    internal class ScenarioTest
    {
        public void TestDealerStandsWhenPlayerBusts()
        {
            Console.SetPlayerResponse(new TestAlwaysHitResponse());
            int[] deck = {10, 9, 7, 2, 6};
            var blackjack = new Blackjack(deck, new BufferedReader());
            blackjack.Play();
            AssertTrue("dealer wins", blackjack.DidDealerWin());
            AssertTrue("player loses", !blackjack.DidPlayerWin());
            AssertEquals("dealer total", 11, blackjack.GetDealerTotal());
            AssertEquals("player total", 23, blackjack.GetPlayerTotal());
        }

        private static void AssertEquals(string message, int left, int right)
        {
        }

        private static void AssertTrue(string message, bool predicate)
        {
        }
    }
}
