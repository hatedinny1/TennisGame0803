using System.Collections.Generic;

namespace TennisGame0803
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScoreTimes;

        public string GetScore()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                return _scoreLookUp[_firstPlayerScoreTimes] + "_" + _scoreLookUp[_secondPlayerScoreTimes];
            }

            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen_All";
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