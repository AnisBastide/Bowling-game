using NUnit.Framework;
using BowlingGame;

namespace BowlingGameTests
{
    [TestFixture]
    public class GameWithPinsTests
    {
        [Test]
        public void ScoreIsZeroWhenAllRollsMissed()
        {
            //Arrange
            var bowling = new GameWithPins();

            //act
            for (int i = 0; i < 20; i++)
            {
                bowling.Roll(0);
            }

            var result = bowling.Score();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ScoreIsTwentyWhenEveryRollKnockOnePin()
        {
            //Arrange
            var bowling = new GameWithPins();

            //act
            for (int i = 0; i < 20; i++)
            {
                bowling.Roll(1);
            }

            var result = bowling.Score();

            //Assert
            Assert.AreEqual(20, result);
        }

        [Test]
        public void ScoreIsSixteenWhenASpareIsDoneAndThenThreePinsAndThenAllMissed()
        {
            //Arrange
            var bowling = new GameWithPins();

            //act
            bowling.Roll(3);
            bowling.Roll(7);
            bowling.Roll(3);
            for (int i = 0; i < 17; i++)
            {
                bowling.Roll(0);
            }

            var result = bowling.Score();

            //Assert
            Assert.AreEqual(16, result);
        }

        [Test]
        public void ScoreIsTwentyFour()
        {
            //Arrange
            var bowling = new GameWithPins();

            //act
            bowling.Roll(10);
            bowling.Roll(3);
            bowling.Roll(4);
            for (int i = 0; i < 16; i++)
            {
                bowling.Roll(0);
            }

            var result = bowling.Score();

            //Assert
            Assert.AreEqual(24, result);
        }

        [Test]
        public void AllStrike()
        {
            //Arrange
            var bowling = new GameWithPins();

            //act
            for (int i = 0; i < 12; i++)
            {
                bowling.Roll(10);
                var score = bowling.Score();
            }
            var result = bowling.Score();
            //Assert
            Assert.AreEqual(300, result);
        }
    }
}
