using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame0803
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void FIfteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty_Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Love_Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Love_Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ScoreShouldBe("Fifteen_All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Thirty_All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_4()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Player1_Adv()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(3);
            ScoreShouldBe("Player1_Adv");
        }

        [TestMethod]
        public void Player2_Adv()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(4);
            ScoreShouldBe("Player2_Adv");
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.GetScore());
        }
    }
}