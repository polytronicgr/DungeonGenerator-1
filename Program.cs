using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO Error handling
//TODO Print results

namespace DungeonGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValidCoordinates = false;
            int XValue = 0;
            int YValue = 0;
            string Entrance = "default";
            int NumRooms = 0;
            const int MinGridSize = 10;
            const int MinNumRooms = 3;

            #region Parse args 
            foreach ( string s in args)
            {
                if (s.StartsWith("-c"))
                {
                    string[] SplitS = s.Split('/');
                    if(SplitS[1] == null || SplitS[2] == null)
                    {
                        //TODO
                        //need to throw error for not enough paramaters for X and Y values
                    }

                    if (IsInt(SplitS[1]) && IsInt(SplitS[2]))
                    {
                        XValue = Convert.ToInt32(SplitS[1]);
                        YValue = Convert.ToInt32(SplitS[2]);

                        if(XValue >= MinGridSize && YValue >= MinGridSize)
                        {
                            ValidCoordinates = true;
                        }
                        else
                        {
                            //TODO
                            //neet to throw error for not a large enough grid
                        }

                    }
                    else
                    {
                        //TODO
                        //need to throw error for incorrect X and Y format (must be integer values)
                    }
                }
                else if (s == "-srandom")
                {
                    Entrance = "random";
                }
                else if (s.StartsWith("-r"))
                {
                    string[] SplitS = s.Split('/');
                    if(SplitS[1] != null && IsInt(SplitS[1]))
                    {
                        NumRooms = Convert.ToInt32(SplitS[1]);
                    }
                }
            }

            if (!ValidCoordinates)
            {
                //TODO
                //need to throw error for no X and Y value provided
            }
            #endregion

            GenerateGrid GridGen = new GenerateGrid();
            if(NumRooms > MinNumRooms)
            {
                GridGen.Generate(XValue, YValue, Entrance, NumRooms);
            }
            else
            {
                GridGen.Generate(XValue, YValue, Entrance);
            }
            
            //do something with result
        }

        static bool IsInt(string s)
        {
            foreach (char c in s)
            {
                if (Char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
