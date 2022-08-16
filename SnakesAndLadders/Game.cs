using SnakesAndLadders.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Game
    {
        public const string GAME_IS_OVER = "Game is over";
        private List<Player> _listPlayers = new List<Player>();
        private readonly IDice _dice;
        private Board board = new();
        private Player player = new();


        public int AssignStartPosition(int numberOfPlayers)
        {
            int position = 0;
            if (numberOfPlayers > 1 && numberOfPlayers <= 10)
            {
                Console.WriteLine();
                if (_listPlayers.Count == 0)
                {
                    _listPlayers = new List<Player>(Enumerable.Range(1, numberOfPlayers).Select(x => new Player()));
                }

                int sec = 1;

                foreach (Player item in _listPlayers)
                {
                    if (item.Id == 0)
                    {
                        item.Id = sec;
                        position = item.CurrentPosition = board.StartValue;
                    }
                    sec++;
                }

            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido de jugadores, presione enter para continuar");
                Console.ReadLine();
                UtilOption util = new();
                util.Options(1);
            }

            return position;
        }

        public void StartGame()
        {
            bool gameOver = false;
            if (_listPlayers.Count > 1)
            {

                foreach (Player item in _listPlayers)
                {

                    Console.WriteLine("Jugador " + item.Id.ToString() + ", presione enter para lanzar el dado");
                    Console.ReadLine();

                    int dieNumber = player.RollDice();

                    int iniPos = item.CurrentPosition;

                    var playerPosition = AssignDicePosition(item, dieNumber);

                    int currentPos = GetElementPosition(playerPosition.CurrentPosition);

                    item.CurrentPosition = currentPos;

                    if (item.CurrentPosition != iniPos)
                    {
                        Console.WriteLine("Jugador " + item.Id.ToString() + ", el valor del dado fue : " + dieNumber + ", se moverá desde la posición '" + iniPos + "' a la posición '" + currentPos + "'");
                    }

                    if (currentPos == board.EndValue)
                    {
                        currentPos = board.EndValue;
                        gameOver = true;
                        bool isWinner = true;
                        item.IsWinner = isWinner;
                    }

                    if (!gameOver)
                    {
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Jugador " + item.Id.ToString() + " ha ganado el juego");
                        Console.ReadLine();
                        break;
                    }

                }

                if (!gameOver) StartGame();
            }

        }

        public Player AssignDicePosition(Player player, int diceNumber)
        {
            int nextSquare = player.CurrentPosition + diceNumber;

            if (nextSquare > board.EndValue)
            {
                Console.WriteLine("Jugador " + player.Id.ToString() + ", el valor del dado fue : " + diceNumber + " ha excedido el número de casillas '" + " se queda en la misma posición '" + player.CurrentPosition + "'");
                return player;
            }
            player.IsWinner = nextSquare == board.EndValue;

            player.CurrentPosition = nextSquare;
            return player;
        }

        public int GetElementPosition(int currentPos)
        {
            Ladder ladder = new();
            Snake snake = new();

            Ladder ladderPosition = ladder.Getladder().Where(x => x.EndPos == currentPos).FirstOrDefault();

            if (ladderPosition == null || ladderPosition.InitPos < 1)
            {
                Snake snakePosition = snake.Getsnake().Where(x => x.InitPos == currentPos).FirstOrDefault();
                if (snakePosition != null && snakePosition.EndPos > 0)
                {
                    Console.WriteLine("Ha caido en una casilla de serpientes, retrocede " + (currentPos - snakePosition.EndPos) + " casillas");
                    currentPos = snakePosition.EndPos;
                }
            }
            else
            {
                Console.WriteLine("Ha caido en una casilla de escalera, avanza " + (ladderPosition.InitPos - currentPos) + " casillas");
                currentPos = ladderPosition.InitPos;
            }

            return currentPos;
        }

    }
}
