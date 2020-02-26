using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public class Cell
    {
        private Coordinate _coordinate;

        public Cell(Coordinate coordinate)
        {

            _coordinate = coordinate;
        }

        public Coordinate Coordinate
        {
            get
            {
                return this.Coordinate;
            }
        }


    }
}