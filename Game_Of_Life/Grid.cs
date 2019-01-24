using System;
using System.Collections.Generic;
using System.Text;

//this creates the grid and handles game logic.
namespace Game_Of_Life
{
    class Grid
    {
        Cell[,] gameGrid;

        public Grid()
        {
            this.gameGrid = new Cell[Int64.MaxValue, Int64.MaxValue];
        }
    }
}
