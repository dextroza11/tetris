using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _sym;
        private Random _rand = new Random();
        public FigureGenerator(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;

        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, 2) == 0)
            {
                return new Stick(_x, _y, _sym);
                
            }

            else
            {
                return new Square(_x, _y, _sym);
            }

        }
    }
}
