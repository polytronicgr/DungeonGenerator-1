using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGenerator
{
    public class GenerateGrid
    {
        //Two dimensional grid for holding all the cells.
        //Y axis is the first number since Y corresponds to the rows in the array (TDGrid[Y,X]).
        Cell[ , ] TDGrid;
        Cell[] PathCells;
        const int MinNumRooms = 3;
        const int MaxPathSegment = 5;
        int MaxNumRooms;
        int RoomCount = 0;

        public void Generate(int x, int y, string start, int numRooms)
        {
            #region CreateGrid
            //Make all the cells.
            Grid(x, y);

            //random number generator will be used throughout the generator.
            Random Rand = new Random();
            MaxNumRooms = (x * y) / 50;
            Cell Entrance;

            //Pick an Entrance location
            if ( start == "default")
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
                int EntranceSide = Rand.Next(1 , 4);
                switch (EntranceSide.ToString())
                {
                    case "1":
                        Entrance = TDGrid[0, Rand.Next(0, x - 1)];
                        break;
                    case "2":
                        Entrance = TDGrid[Rand.Next(0, y - 1), 0];
                        break;
                    case "3":
                        Entrance = TDGrid[y - 1, Rand.Next(0, x - 1)];
                        break;
                    case "4":
                        Entrance = TDGrid[Rand.Next(0, y - 1), x - 1];
                        break;
                    //Need a default to prevent an error but this should never be run if my code works properly.
                    default:
                        Entrance = TDGrid[0, Rand.Next(0, x - 1)];
                        break;
                }
            }
            Entrance.Status = "Entrance";
            Entrance.IsAllocated = true;
            #endregion

            #region CreateLayout
            
            if(numRooms < MinNumRooms)
            {
                numRooms = Rand.Next(MinNumRooms, MaxNumRooms);
            }
            //Always start with a path leading from the entrance.
            Path(Entrance, Rand.Next(0, 3).ToString(), Rand.Next(1, MaxPathSegment));
            string LastPlaced = "path";

            while(RoomCount < numRooms)
            {
                if(LastPlaced == "path")
                { 
                    int i = Rand.Next(1, 100);
                    if(i > 40)
                    {
                        //place a room
                    }
                    else
                    {
                        //place more path
                    }
                }
                else
                {
                    int i = Rand.Next(1, 100);
                    if(i <= 25)
                    {
                        //place another room
                    }
                    else if(i <= 65)
                    {
                        //place a path from the room
                    }
                    else
                    {
                        //place path off some other path cell
                    }
                }
            }
            #endregion

        }

        // makes all the cells and stores them in an array.
        private void Grid(int x, int y)
        {
            TDGrid = new Cell[y , x];
            PathCells = new Cell[x * y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Cell cell = new Cell(j, i);
                    TDGrid[i, j] = cell;
                }
            }
        }

        private void Path(Cell startCell,string direction, int length)
        {
            //creates the path the player will walk.
        }
         
        private void Room(Cell startCell)
        {
            //creates the room over the path.
        }
    }
}
