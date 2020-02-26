using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public class Pacman: Subject, IMovable
    {
        int speed = 10;

        public Pacman(Coordinate coordinate) : base(coordinate)
        {


        }

        public Pacman() : base(new Coordinate(20, 9))
        {


        }




    }
}