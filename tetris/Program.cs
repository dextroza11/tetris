using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Program
    {
        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(60, 40);
            int x1 = 2;
            int y1 = 3;
            char c = '*';
            Drow(x1, y1, c);
            Drow(3, 4, c);
            
        }
    }
}
