namespace TennisGame0803
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string GetScore()
        {
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen_Love";
            }
            return "Love_All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}