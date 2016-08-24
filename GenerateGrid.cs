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
        Cell Entrance;

        public void Generate(int x, int y, string start)
        {

            //all the logic.
        }

        public void Generate(int x, int y, string start, int numRooms)
        {
            //Make all the cells
            Grid(x, y);

            //Pick an Entrance location
            if( start == "default")
            {
                int Middle;
                if ((x % 2) == 0)
                {
                    Middle = x / 2;
                }
                else
                {
                    Middle = (x +1) / 2;
                }
                //default location is bottom middle cell.
                Entrance = TDGrid[0, Middle];
            }
            else
            {
                Random Rndm = new Random();
                int EntranceSide = Rndm.Next(1 , 4);
                switch (EntranceSide.ToString())
                {
                    case "1":
                        Entrance = TDGrid[0, Rndm.Next(0, x - 1)];
                        break;
                    case "2":
                        Entrance = TDGrid[Rndm.Next(0, y - 1), 0];
                        break;
                    case "3":
                        Entrance = TDGrid[y - 1, Rndm.Next(0, x - 1)];
                        break;
                    case "4":
                        Entrance = TDGrid[Rndm.Next(0, y - 1), x - 1];
                        break;
                }
            }
            Entrance.Status = "Entrance";
            Entrance.IsAllocated = true;

        }

        // makes all the cells and stores them in an array.
        private void Grid(int x, int y)
        {
            TDGrid = new Cell[y , x];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
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
