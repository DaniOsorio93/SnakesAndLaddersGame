using System;

namespace SnakesAndLadders.Util
{
    public class UtilOption
    {
        public bool Options(int option)
        {

            Console.Clear();
            int numberOfPlayers = 0;
            bool goOut = false;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de jugadores(2-10)");
                    numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                    Game game = new Game();
                    game.AssignStartPosition(numberOfPlayers);
                    game.StartGame();
                    break;
                case 2:
                    goOut = true;
                    break;
            }

            return goOut;
        }
    }
}
