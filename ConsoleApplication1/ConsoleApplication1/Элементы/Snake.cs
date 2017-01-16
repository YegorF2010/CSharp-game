using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Snake:Figure {
        Direction direction; //благодаря методу HandleKey перечисление можно сделать private

        public Snake(Point tail,int length, Direction _direction) {
            plist=new List<Point>();
            direction=_direction;
            for (int i = 0; i< length; i++) {
                var p = new Point(tail);
                p.Move(i, _direction);
                plist.Add(p);
            }
        }

        public void Move() {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public override bool IsHit(Figure snake) {
            for(int i=0;i<plist.Count-1;i++) {  //Count-1 !!!т.к. с головой сравнивать не надо!
                if (plist[i].IsHit(snake.GetHead()))
                    return true;
            }
            return false;
        }

        public bool Eat(Point food) {
            Point head = GetNextPoint();

            if (head.IsHit(food)) {
                food.symbol=head.symbol;    //без этой строки все символы змейки станут $ 
                plist.Add(food);
                return true;
            }
            else
                return false;
        }

        Point GetNextPoint() {
            Point head = plist.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;

            //head.Move(1, direction);
            //return head;
        }
        public void HandleKey(ConsoleKeyInfo key) { //ConsoleKeyInfo - это структура 
            if (key.Key==ConsoleKey.LeftArrow)      //у нее есть поле Key типа ConsoleKey
                direction=Direction.LEFT;
            else if (key.Key==ConsoleKey.RightArrow)
                direction=Direction.RIGHT;
            else if (key.Key==ConsoleKey.UpArrow)
                direction=Direction.UP;
            else if (key.Key==ConsoleKey.DownArrow)
                direction=Direction.DOWN;
        }
        public int GetLength() {
            return plist.Count;
        }
    }
}
