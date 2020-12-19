using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Stick:Figure
    {
        
        public Stick(int x, int y, char c)
        {
            for(int i = 0; i < p.Length; i++)
            {
                p[i] = new Point(x, y + i, c);
            }

            Draw();
        }

        public override void Rotate()
        {
            Hide();
            if (p[0].x == p[1].x)
            {
                RotateHorizontal();
            }

            else
            {
                RotateVertical();
            }
            Draw();
            
        }

        public void RotateHorizontal()
        {
            int y_const = p[0].y;
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Point(p[0].x + i, y_const, p[0].c);
            }

        }

        public void RotateVertical()
        {
            int x_const = p[0].x;
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Point(x_const, p[0].y + i, p[0].c);
            }

        }







    }
}
