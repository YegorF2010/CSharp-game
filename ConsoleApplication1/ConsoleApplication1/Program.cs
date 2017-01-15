using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            var line1 = new Framework();
            line1.Draw2();


            var p = new Point(4, 6, '*');
            var snake = new Snake(p,5,Direction.RIGHT);
            snake.Draw2();


            Console.ReadLine();
        }
    }
}
