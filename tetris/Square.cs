using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Square:Figure
    {

        public Square(int x, int y, char c)
        {
            
            p[0] = new Point(x, y, c);
            p[1] = new Point(x+1, y, c);
            p[2] = new Point(x, y + 1, c);
            p[3] = new Point(x + 1, y + 1, c);
            Draw();

        }

        public override void Rotate()
        {
            
        }


    }
}
