using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Snake
    {
        public int InitPos { get; set; }
        public int EndPos { get; set; }

        public List<Snake> Getsnake()
        {
            return new List<Snake>()
        {
            new Snake { InitPos = 16, EndPos = 6},
            new Snake { InitPos = 49, EndPos = 11},
            new Snake { InitPos = 62, EndPos = 19},
            new Snake { InitPos = 46, EndPos = 25},
            new Snake { InitPos = 64, EndPos = 60},
            new Snake { InitPos = 74, EndPos = 53},
            new Snake { InitPos = 89, EndPos = 68},
            new Snake { InitPos = 92, EndPos = 88},
            new Snake { InitPos = 95, EndPos = 75},
            new Snake { InitPos = 99, EndPos = 80}
        };
        }
    }
}
