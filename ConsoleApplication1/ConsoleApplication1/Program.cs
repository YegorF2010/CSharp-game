using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            var line1 = new Framework();
            line1.Draw();


            var p = new Point(_x:1, _y:6, _s:'*');
            var snake = new Snake(tail:p,length:4,_direction:Direction.RIGHT);
            snake.Draw();

            while (true) {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                snake.Move();
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }
    }
}
