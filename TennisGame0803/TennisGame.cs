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
        };

        public string GetScore()
        {
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
    }
}