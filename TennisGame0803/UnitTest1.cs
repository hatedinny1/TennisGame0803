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
            tennisGame.FirstPlayerScore();
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Thirty_Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.GetScore());
        }
    }
}