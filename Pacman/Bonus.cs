using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public class Bonus:Thing
    {
        private EnumBonus _typeOfBonus;


        Bonus(EnumBonus typeOfBonus, Coordinate coordinate):base(coordinate)
        {

        }
    }
}