using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Point {
        public int x { get; set; }
        public int y { get; set; }
        char symbol;

        public Point() { }
        public Point(Point p) {
            x=p.x;y=p.y;symbol=p.symbol;
        }
        public Point(int _x,int _y,char _s) {
            x=_x;y=_y;symbol=_s;
        }

        public void Draw() {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Move(int offset,Direction dir) {
            switch (dir) {
                case Direction.LEFT:  x=x-offset;break;
                case Direction.RIGHT:  x=x+offset;break;
                case Direction.UP:  y=y-offset;break;
                case Direction.DOWN:  y=y+offset;break;
            }
        }
        public void Clear() {
            symbol=' ';
            Draw();
        }
        public override string ToString() {
            return x+", "+y+", "+symbol;
        }
    }
}
