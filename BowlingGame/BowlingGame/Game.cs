using System;

namespace BowlingGame

{
    public class Game
    {
        private int _score;
        private int _pinCount = 10;
        private bool _spare;
        private bool _strike;
        private bool _secondStrike;
        private int _frameNumber=0;

        public void Roll(int firstRoll, int secondRoll)
        {
            

            if (_frameNumber >= 10)
            {
                Score(firstRoll,secondRoll);
            }
            else
            {
                if (_spare)
                {
                    Spare(firstRoll);
                }
                if (_strike)
                {
                    Strike(firstRoll, secondRoll);
                }
                IsSpareOrStrike(firstRoll, secondRoll);

                Score(firstRoll, secondRoll);
                _frameNumber++;
            }
            
        }

        private void Score(int firstRoll, int secondRoll)
        {
            _pinCount -= firstRoll;
            _pinCount -= secondRoll;
            if (_pinCount < 0)
            {
                throw new Exception("You can't knock more than 10 pins");
            }

            _score += Math.Abs(_pinCount - 10);
            _pinCount = 10;
        }

        private void IsSpareOrStrike(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
            {
                Console.WriteLine("Strike");
                _strike = true;
            }

            if (secondRoll + firstRoll == 10 && firstRoll!= 10)
            {
                Console.WriteLine("Spare");
                _spare = true;
            }
        }

        public int GetScore()
        {
            return _score;
        }

        private void Spare(int firstRoll)
        {
            _score+=firstRoll;
            _spare = false;
        }
        private void Strike(int firstRoll, int secondRoll)
        {
            IsSecondStrike(firstRoll);
            if (_secondStrike)
            {
                _score += firstRoll;
            }
            _score += firstRoll + secondRoll;
            _strike = false;
        }

        private void IsSecondStrike(int firstRoll)
        {
            if (firstRoll == 10)
            {
                _secondStrike = true;
            }
            else
            {
                _secondStrike = false;
            }
        }
    }
}