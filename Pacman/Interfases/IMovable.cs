using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public interface IMovable
    {
        void Move(Coordinate currentCoordinate, Coordinate nextCoordinate);               

    }
}