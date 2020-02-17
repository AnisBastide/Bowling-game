namespace BowlingGame
{
    public class GameWithPins
    {
        private int _score;
        private int _rollNumber = 1;
        private int _knockedPins;
        private bool _strike;
        private bool _spare;
        private int _strikeCount;
        private int _frameNumber=1;
        private bool _secondStrike;

        public void Roll(int pins)
        {
            if (_frameNumber > 10)
            {
                _score += pins;
            }
            else
            {
                if (_strike)
                {
                    Strike(pins);
                }

                if (_spare)
                {
                    Spare(pins);
                }
                RollNumber(pins);

                if (_secondStrike)
                {
                    _score += pins;
                }

                _score += pins;
            }
        }

        private void RollNumber(int pins)
        {
            if (_rollNumber == 1)
            {
                _knockedPins += pins;
                if (_frameNumber > 1)
                {
                    SecondStrike(pins);
                }
                IsSpareOrStrike(pins);

                if (_strike != true)
                {
                    _rollNumber = 2;
                }
            }
            else if (_rollNumber == 2)
            {
                _knockedPins += pins;
                IsSpareOrStrike(pins);
                _rollNumber = 1;
            }
        }

        private void IsSpareOrStrike(int pins)
        {
            if (_rollNumber == 1 && _knockedPins == 10)
            {
                _knockedPins = 0;
                _strike = true;
                _frameNumber++;
            }
            else if (_rollNumber == 2 && _knockedPins == 10)
            {
                _spare = true;
                _knockedPins = 0;
                _frameNumber++;
            }
            else if (_rollNumber == 2)
            {
                _knockedPins = 0;
                _frameNumber++;
            }
        }

        private void Strike(int pins)
        {
            if (_strikeCount == 0 && _strike)
            {
                _strikeCount += 1;
                _score += pins;
            }
            else if (_strikeCount == 1 && _strike)
            {
                _strike = false;
                _strikeCount = 0;
                _score += pins;
            }
        }

        private void SecondStrike(int pins)
        {
            if (_knockedPins == 10)
            {
                _secondStrike = true;
            }
            else
            {
                _secondStrike = false;
            }
        }

        private void Spare(int pins)
        {
            _spare = false;
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
