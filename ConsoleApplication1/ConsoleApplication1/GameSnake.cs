using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class GameSnake: IGameStrategy {
        Framework frame;                //Фасад
        Point pStart;
        Point pFood;
        Snake snake;
        Food food;

        public GameSnake() {
            frame=new Framework();
            pStart= new Point(_x: 1, _y: 6, _s: '*');
            snake=new Snake(tail: pStart, length: 4, _direction: Direction.RIGHT);
            food=new Food();
        }

        public void InitGame() {
            frame.Draw();
            snake.Draw();

            pFood = food.CreateFood();
            pFood.Draw();
        }
        public void NextTurn() {
            if (Console.KeyAvailable) {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key);
            }
            if (snake.Eat(pFood)) {
                pFood=food.CreateFood();
                pFood.Draw();
            }
            else snake.Move();

            Thread.Sleep(100);
        }

        public bool IsGameOver() {         
            return frame.IsHit(snake)||snake.IsHit(snake);
        }
        public void GetTotalResult() {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor=ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset+1, yOffset++);
            WriteText($"-Результат: {snake.GetLength()}", xOffset+1, yOffset++);
            yOffset++;
            WriteText("Автор: Георгий Петров", xOffset+2, yOffset++);        
            WriteText("============================", xOffset, yOffset++);
        }
        void WriteText(String text, int xOffset, int yOffset) {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
