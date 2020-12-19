using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;
        public Point()
        {

        }
        public void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
        internal void Move(Wasd direction)
        { 

            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            switch (direction)
            {
                case Wasd.DOWN:
                    y += 1;
                    break;
                case Wasd.LEFT:
                    x -= 1;
                    break;
                case Wasd.RIGHT:
                    x += 1;
                    break;
            }


        }
        public Point(int x, int y, char c)
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
