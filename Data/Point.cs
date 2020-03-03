using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chess.Data
{
    public struct Point
    {
        public int Row { get; set; }
        public int Cell { get; set; }
    }

    public enum Level
    {
  
        活3 = 1,
        眠3 = 2

    }

    public class ValuedPoint
    {
        public Point Point { get; set; }
        public int Score { get; set; }

        public int Level { get; set; }
    }
}
