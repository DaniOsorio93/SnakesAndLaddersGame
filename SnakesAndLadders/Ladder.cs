using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Ladder
    {
        public int InitPos { get; set; }
        public int EndPos { get; set; }
        public List<Ladder> Getladder()
        {
            return new List<Ladder>()
        {
            new Ladder { EndPos = 2, InitPos = 38},
            new Ladder { EndPos = 7, InitPos = 14},
            new Ladder { EndPos = 8, InitPos = 31},
            new Ladder { EndPos = 15, InitPos = 26},
            new Ladder { EndPos = 21, InitPos = 42},
            new Ladder { EndPos = 28, InitPos = 84},
            new Ladder { EndPos = 36, InitPos = 44},
            new Ladder { EndPos = 51, InitPos = 67},
            new Ladder { EndPos = 71, InitPos = 91},
            new Ladder { EndPos = 78, InitPos = 98},
            new Ladder { EndPos = 87, InitPos = 94}
        };
        }
    }
}
