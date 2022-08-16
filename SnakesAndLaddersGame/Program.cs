using System;
using SnakesAndLadders.Util;

namespace SnakesAndLaddersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serpientes y Escaleras");

            bool goOut = false;

            while (!goOut)
            {

                Console.WriteLine("1. Empezar Juego");
                Console.WriteLine("2. Salir");
                Console.WriteLine("Elige una de las opciones");
                int option = 2;
                bool valid = false;
                while (!valid)
                {
                    valid = int.TryParse(Console.ReadLine(), out option);
                }

                UtilOption util = new();
                goOut = util.Options(option);

            }
        }
    }
}
