using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGenerator
{
    public class GenerateGrid
    {
        //two dimensional grid for holding all the cells.
        //Y axis is the first number since Y corresponds to the rows in the array (TDGrid[Y,X])
        Cell[ , ] TDGrid;

        public void Generate(int X, int Y, string Start)
        {

            //all the logic.
        }

        public void Generate(int X, int Y, string Start, int NumRooms)
        {

            //all the logic.
        }

        // makes all the cells and stores them in an array.
        private void Grid(int X, int Y)
        {
            TDGrid = new Cell[Y , X];
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Cell cell = new Cell(j, i);
                    TDGrid[i, j] = cell;
                }
            }
        }

        private void Path()
        {
            //creates the path the player will walk
        }

        private void Rooms()
        {
            //creates the rooms over the path.
        }
    }
}
