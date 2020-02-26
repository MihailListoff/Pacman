using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacman pacman = new Pacman();
            RedGhost redGhost = new RedGhost();
            Maze maze = new Maze(pacman, redGhost);
            Console.ReadKey();
        }
    }
}
