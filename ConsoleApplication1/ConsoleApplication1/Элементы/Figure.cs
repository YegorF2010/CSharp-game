using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Figure {
        protected List<Point> plist;

        public void Draw() {
            foreach (var el in plist)
                el.Draw();
        }
        public Point GetHead() {
            return plist.Last();
        }
        public virtual bool IsHit(Figure snake) {
            foreach (var el in plist) {
                if (el.IsHit(snake.GetHead()))
                    return true;
            }
            return false;
        }
    }
}
