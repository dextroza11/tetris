using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tetris
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(60, 40);

            //Square sq = new Square(1, 1, 'x');
            //Figure myFigyre;
            FigureGenerator generator = new FigureGenerator(5, 5, '*');
            Figure currFigure = generator.GetNewFigure();
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    HandleKey(key, currFigure);  
                }
                
            }




           

            void FigureFall(Figure myFigure)
            {

                
                for (int i = 0; i < 10; i++)
                {
                    myFigure.Draw();
                    Thread.Sleep(200);
                    myFigure.Hide();
                    myFigure.Move(Wasd.DOWN);
                }
               

            }



            Console.Read();


          

            
        }

        private static void HandleKey(ConsoleKeyInfo key, Figure currFigure)
        {
            if(key.Key == ConsoleKey.RightArrow)
            {
                if (currFigure.TryRight())
                {
                    currFigure.Move(Wasd.RIGHT);
                }
           
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {

                if (currFigure.TryLeft())
                {
                    currFigure.Move(Wasd.LEFT);
                }
                

            }
            if (key.Key == ConsoleKey.DownArrow) {
                if (currFigure.TryDown())
                {
                    currFigure.Move(Wasd.DOWN);
                }

            }
            if (key.Key == ConsoleKey.Spacebar)
            {
                if (currFigure.TryRotate())
                {
                    currFigure.Rotate();
                }
            }

        }
    }
}
