using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Point
    {
        int x;
        int y;
        char c;
        Point(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public void Draw()
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(c);

        }
    }
}
