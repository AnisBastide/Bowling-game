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
            var bowlingGame = new Game();
            //Act
            for (int i = 0; i <= 10; i++)
            {
                bowlingGame.Roll(0,0);
            }

            //Assert
            Assert.AreEqual(0,bowlingGame.GetScore());
        }
        [Test]
        public void OnePinEachRoll()
        {
            //Arrange
            var bowlingGame = new Game();
            //Act
            for (int i = 0; i < 10; i++)
            {
                bowlingGame.Roll(1,1);
            }

            //Assert
            Assert.AreEqual(20,bowlingGame.GetScore());
        }
        [Test]
        public void SixteenScore()
        {
            //Arrange
            var bowlingGame = new Game();
            //Act
            bowlingGame.Roll(7,3);
            bowlingGame.Roll(3,0);
            for (int i = 0; i < 8; i++)
            {
                bowlingGame.Roll(0,0);
            }

            //Assert
            Assert.AreEqual(16,bowlingGame.GetScore());
        }
        [Test]
        public void TwentyFourScore()
        {
            //Arrange
            var bowlingGame = new Game();
            //Act
            bowlingGame.Roll(10, 0);
            bowlingGame.Roll(3,4);
            for (int i = 0; i < 8; i++)
            {
                bowlingGame.Roll(0,0);
            }

            //Assert
            Assert.AreEqual(24,bowlingGame.GetScore());
        }
        [Test]
        public void AllStrike()
        {
            //Arrange
            var bowlingGame = new Game();
            //Act
            for (int i = 0; i < 12; i++)
            {
                bowlingGame.Roll(10,0);
            }

            //Assert
            Assert.AreEqual(300,bowlingGame.GetScore());
        }
    }
}
