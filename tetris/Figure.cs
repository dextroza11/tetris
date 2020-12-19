using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
   abstract class Figure
    {

        protected Point [] p = new Point[4];
        public void Move(Wasd direction)
        {

            Hide();
            foreach (var point in p)
            {
                point.Move(direction);

            }

            Draw();

        }
        public abstract void Rotate();

        public void Hide()
        {
            foreach(var el in p)
            {
                el.Hide();
            }
        }
        public void Draw()
        {
            foreach(var elem in p)
            {
                elem.Draw();
            }
        }

        public bool TryLeft()
        {
            return p[0].x <= 0 ? false : true;
        }
        public bool TryRight()
        {
            return p[3].x >= 59 ? false : true;
        }

        public bool TryDown()
        {
            return p[3].y >= 39 ? false : true;
        }

        public bool TryRotate()
        {
            if(p[0].x == p[1].x)
            {
                return p[0].x + 4 >= 59 ? false : true;
            }
            else
            {
                return p[3].y + 4 >= 39 ? false : true;
            }


        }

    }
}
