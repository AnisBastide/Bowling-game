using System;

namespace BowlingGame

{
    public class Game
    {
        private int _score;
        private int _pinCount=10  ;
        public void Roll(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
            {
                Console.WriteLine("Strike");
            }
            if (secondRoll+firstRoll == 10)
            {
                Console.WriteLine("Spare");
            }
            _pinCount -= firstRoll;
            _pinCount -= secondRoll;
            if (_pinCount < 0)
            {
                throw new Exception("You can't knock more than 10 pins");
            }
            _score += Math.Abs(_pinCount - 10);
            _pinCount = 10;
            
        }

        public int Score()
        {
            return _score;
        }
    }
}