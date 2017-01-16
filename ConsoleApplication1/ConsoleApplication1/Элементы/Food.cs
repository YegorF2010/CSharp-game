using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Food {
        int mapWidth;
        int mapHeight;

        public Food(int _mapWidth=80, int _mapHeight = 25) {
            mapWidth=_mapWidth;
            mapHeight=_mapHeight;
        }
        public Point CreateFood() {                     //Фабричный метод
            int x = new Random().Next(2, mapWidth-2);
            int y= new Random().Next(2, mapHeight-2);
            return new Point(x,y,'$');
        }
    }
}
