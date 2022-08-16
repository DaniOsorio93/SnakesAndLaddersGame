namespace SnakesAndLadders
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int CurrentPosition { get; set; } = 1;
        public bool IsWinner { get; set; }



        public int RollDice()
        {
            int diceValue = 0;

            Dice die = new();
            diceValue = die.GetDiceValue();

            return diceValue;
        }


    }
}
