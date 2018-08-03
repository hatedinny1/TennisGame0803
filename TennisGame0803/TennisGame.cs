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
            return IsDifferentScore()
                ? (IsGamePoint() ? (IsAdv() ? Adv() : Win()) : NormalScoreLookUp())
                : (IsDeuce() ? Deuce() : SameScore());
        }

        private string SameScore()
        {
            return _scoreLookUp[_firstPlayerScoreTimes] + "_All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3 && _firstPlayerScoreTimes == _secondPlayerScoreTimes;
        }

        private string NormalScoreLookUp()
        {
            return _scoreLookUp[_firstPlayerScoreTimes] + "_" + _scoreLookUp[_secondPlayerScoreTimes];
        }

        private string Win()
        {
            return GetAdvPlayer() + "_Win";
        }

        private string Adv()
        {
            return GetAdvPlayer() + "_Adv";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScoreTimes >= 4 || _secondPlayerScoreTimes >= 4;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
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