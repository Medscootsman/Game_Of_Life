using System;
using System.Collections.Generic;
using System.Text;

//this is the cell, each cell object can keep track of it's neighbours.
namespace Game_Of_Life
{
    class Cell
    {
        bool alive;
        int maxNeighbours = 3;
        int minNeighbours = 2;
        int currentNeighbours;

        Cell N_Neighbour;
        Cell NE_Neighbour;
        Cell E_Neighbour;
        Cell SE_Neighbour;
        Cell S_Neighbour;
        Cell SW_Neighbour;
        Cell W_Neighbour;
        Cell NW_Neighbour;



    }
}
