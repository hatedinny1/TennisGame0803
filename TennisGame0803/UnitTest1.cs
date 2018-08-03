using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame0803
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love_All", score);
        }
    }
}