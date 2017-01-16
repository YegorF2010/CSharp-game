using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            var frame = new Framework();
            frame.Draw();

            var p = new Point(_x:1, _y:6, _s:'*');
            var snake = new Snake(tail:p,length:4,_direction:Direction.RIGHT);
            snake.Draw();

            var food = new Food();
            var pFood = food.CreateFood();
            pFood.Draw();

            while (true) {
                if (frame.IsHit(snake) || snake.IsHit(snake)) {
                    Console.WriteLine("Столкновение!");
                    break;
                }
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                if (snake.Eat(pFood)) {
                    pFood = food.CreateFood();
                    pFood.Draw();
                }
                else {
                    snake.Move();
                }          
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
