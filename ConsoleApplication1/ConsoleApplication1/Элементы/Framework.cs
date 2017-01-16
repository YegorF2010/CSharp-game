using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Framework:Figure {

        public Framework() {
            Console.SetBufferSize(80,25);   // !!!!!!!(убирает возможность перемотки)
            char sym = '+';
            plist=new List<Point>();
            //вверх
            for (int i = 0; i<=78; i++) {
                var p = new Point(i, 0, sym);
                plist.Add(p);
            }
            //низ
            for (int i = 0; i<=24; i++) {
                var p = new Point(0, i, sym);
                plist.Add(p);
            }
            //лево
            for (int i = 0; i<=24; i++) {
                var p = new Point(78, i, sym);
                plist.Add(p);
            }
            //право
            for (int i = 0; i<=78; i++) {
                var p = new Point(i, 24, sym);
                plist.Add(p);
            }
        }

    }
}
