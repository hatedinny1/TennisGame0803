using System.Collections.Generic;

namespace TennisGame0803
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScoreTimes;

        public string GetScore()
        {
            if (_secondPlayerScoreTimes == 1)
            {
                return "Love_Fifteen";
            }
            if (_firstPlayerScoreTimes > 0)
            {
                return _scoreLookUp[_firstPlayerScoreTimes] + "_Love";
            }
            return "Love_All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}