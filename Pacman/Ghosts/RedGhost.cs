using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public class RedGhost : Ghost, IMovable
    {
        public RedGhost(Coordinate coordinate) : base(coordinate)
        {


        }

        public RedGhost():base(new Coordinate(2, 4))
        {


        }
    }
}