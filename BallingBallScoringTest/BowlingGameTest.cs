using BallingBallScoring;
using NUnit.Framework;

namespace BallingBallScoringTest
{
    public class Tests
    {
        BowlingGame game;

        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        [Test]
        public void SameValueOPfin()
        {
            for (int i = 0; i < 20; i++)
                game.Roll(3);
            Assert.AreEqual(60, game.Score());
        }

        [Test]
        public void PerfectGame()
        {
            for (int i = 0; i < 20; i++)
                game.Roll(10);
            Assert.AreEqual(300, game.Score());
        }

        [Test]
        public void GivenTestCase()
        {
            for(int i = 0; i < 20; i++)
            {
                game.Roll(10);
                game.Roll(9);
                game.Roll(1);
                game.Roll(5);
                game.Roll(5);
                game.Roll(7);
                game.Roll(2);
                game.Roll(10);
                game.Roll(10);
                game.Roll(10);
                game.Roll(9);
                game.Roll(0);
                game.Roll(8);
                game.Roll(2);
                game.Roll(9);
                game.Roll(1);
                game.Roll(10);
            }
            Assert.AreEqual(187, game.Score());
        }
    }
}