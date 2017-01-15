using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Point {
        int x, y;
        char symbol;

        public Point() { }
        public Point(int _x,int _y,char _s) {
            x=_x;y=_y;symbol=_s;
        }

        public void Draw() {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
