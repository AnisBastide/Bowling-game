using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTests
{
    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void AllRollsMissed()
        {
            //Arrange
            var BowlingGame = new Game();
            //Act
            for (int i = 0; i <= 20; i++)
            {
                BowlingGame.Roll(0);
            }

            //Assert
            Assert.AreEqual(0,BowlingGame.Score());
        }
        [Test]
        public void OnePinEachRoll()
        {
            //Arrange
            var BowlingGame = new Game();
            //Act
            for (int i = 0; i < 20; i++)
            {
                BowlingGame.Roll(1);
            }

            //Assert
            Assert.AreEqual(20,BowlingGame.Score());
        }
        [Test]
        public void SixteenScore()
        {
            //Arrange
            var BowlingGame = new Game();
            //Act
            BowlingGame.Roll(13);
            BowlingGame.Roll(3);
            for (int i = 0; i < 18; i++)
            {
                BowlingGame.Roll(0);
            }

            //Assert
            Assert.AreEqual(16,BowlingGame.Score());
        }
    }
}
