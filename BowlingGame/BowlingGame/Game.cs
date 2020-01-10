using System;

namespace BowlingGame

{
    public class Game
    {
        private int score;
        private int rollCount;
        private int pinCount;
        public void Roll(int knockedPins)
        {
            if (knockedPins == 20)
            {

            }
            if (rollCount == 1)
            {
                
                rollCount = 2;
            }

            if (rollCount == 2)
            {
                rollCount = 1;
                score += Math.Abs(pinCount-knockedPins);
                pinCount = 0;
            }
            
        }

        public int Score()
        {
            return score;
        }
    }
}