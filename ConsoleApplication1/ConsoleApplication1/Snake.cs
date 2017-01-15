﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Snake:Figure {
        public Snake(Point tail,int length, Direction direction) {
            plist=new List<Point>();
            for (int i = 0; i< length; i++) {
                var p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }
    }
}
