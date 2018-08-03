using System;
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
                if (_firstPlayerScoreTimes >= 3 || _secondPlayerScoreTimes >= 3)
                {
                    if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
                    {
                        return GetAdvPlayer() + "_Adv";
                    }
                }
                return _scoreLookUp[_firstPlayerScoreTimes] + "_" + _scoreLookUp[_secondPlayerScoreTimes];
            }

            if (_firstPlayerScoreTimes >= 3)
            {
                return "Deuce";
            }
            return _scoreLookUp[_firstPlayerScoreTimes] + "_All";
        }

        private string GetAdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes ? "Player1" : "Player2";
            return advPlayer;
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