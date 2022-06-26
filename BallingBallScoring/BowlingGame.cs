using System.Collections;

namespace BallingBallScoring
{
    public class BowlingGame
    {
        //List to store values of the pins thrown
        ArrayList rolls = new ArrayList();

        //Add rolls to the arrayList
        public void Roll(int roll)
        {
            rolls.Add(roll);
        }

        public int Score()
        {
            int rollIndex = 0;
            int total = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (PinCount(rollIndex) == 10)
                {
                    total += 10 + PinCount(rollIndex + 1) + PinCount(rollIndex + 2);
                    rollIndex++;
                }
                else if (PinCount(rollIndex) + PinCount(rollIndex + 1) == 10)
                {
                    total += 10 + PinCount(rollIndex + 2);
                    rollIndex += 2;
                }
                else
                {
                    total += PinCount(rollIndex) + PinCount(rollIndex + 1);
                    rollIndex += 2;
                }
            }
            return total;
        }

        private int PinCount(int pinPosition)
        {
            return (int)rolls[pinPosition];
        }
    }
}
