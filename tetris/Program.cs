using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(60, 40);
            Point p1 = new Point(2,3, '*');
            p1.Draw();
            
        }
    }
}
