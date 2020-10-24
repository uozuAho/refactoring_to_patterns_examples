namespace inline_singleton.refactored
{
    internal class Blackjack
    {
        private int[] _deck;
        private readonly BufferedReader _input;
        private readonly Player _player;
        private readonly Player _dealer;

        public Blackjack(int[] deck, BufferedReader input)
        {
            _deck = deck;
            _input = input;
            _player = new Player();
            _dealer = new Player();
        }

        public void Play()
        {
            Deal();
            Writeln(_player.GetHandAsString());
            Writeln(_dealer.GetHandAsStringWithFirstCardDown());
            HitStayResponse hitStayResponse;
            do
            {
                Writeln("H)it or S)tay: ");
                hitStayResponse = Console.ObtainHitStayResponse(_input);
                Writeln(hitStayResponse.ToString());
                if (hitStayResponse.ShouldHit())
                {
                    DealCardTo(_player);
                    Writeln(_player.GetHandAsString());
                }
            } while (CanPlayerHit(hitStayResponse));
        }

        private bool CanPlayerHit(HitStayResponse hitStayResponse)
        {
            return false;
        }

        private void DealCardTo(Player player)
        {
        }

        private void Writeln(string message)
        {
        }

        private void Deal()
        {
        }

        public bool DidDealerWin()
        {
            return true;
        }

        public bool DidPlayerWin()
        {
            return !DidDealerWin();
        }

        public int GetDealerTotal()
        {
            return 4;
        }

        public int GetPlayerTotal()
        {
            return 4;
        }
    }
}
