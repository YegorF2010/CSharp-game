using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            var strategy = new Game(new GameSnake());
            strategy.play();

            Console.ReadLine();
        }
    }
}
