using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGenerator
{
    public class Cell
    {
        public bool IsAllocated { get; set; }
        public string Status { get; set; }
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }

        public Cell(int x, int y)
        {
            IsAllocated = false;
            Status = string.Empty;
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
