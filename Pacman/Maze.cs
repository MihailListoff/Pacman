using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public class Maze
    {
        const int weight = 20;
        const int height = 20;
        private Pacman _pacman;
        private static RedGhost _redGhost;
        //private static BlueGhost _blueGhost;
        //private static OrangeGhost _orangeGhost;
        //private static PinkGhost _pinkGhost;
        private Cell[,] _cells = new Cell[height, height];
  //      private Ghost[] _ghosts = new Ghost[4] { _redGhost, _blueGhost, _orangeGhost, _pinkGhost };

        public Maze(Pacman pacman, RedGhost redGhost/*, BlueGhost blueGhost, OrangeGhost orangeGhost, PinkGhost pinkGhost*/)
        {
            _pacman = pacman;
            _redGhost = redGhost;

            _cells[_pacman.Coordinate.X, _pacman.Coordinate.Y] = _pacman;
            _cells[_redGhost.Coordinate.X, _redGhost.Coordinate.Y] = _redGhost;

            //_orangeGhost = orangeGhost;
            //_pinkGhost = pinkGhost;

            for (int i = 0; i < height; ++i)
            {
                for(int j = 0; j < weight; ++j)
                {


                    if(i == 0 || i == height - 1)
                    {

                        if(j == 0 || j == weight - 1)
                        {
                            switch (j)
                            {
                                case 0:
                                    _cells[i, j] = new LeftTopObstacle(new Coordinate(i, j));
                                    break;

                                case weight - 1:
                                    _cells[i, j] = new RightTopObstacle(new Coordinate(i, j));
                                    break;
                            }
                        }
                        else
                        {
                            _cells[i, j] = new HorizontalObstacle(new Coordinate(i, j));
                        }

                    }

                }
            }

        }

    } 
}

   