using System;

namespace SnakesAndLadders
{
    public class Dice : IDice
    {
        public int GetDiceValue()
        {
            Random random = new();
            return random.Next(1, 6);
        }

    }
}
