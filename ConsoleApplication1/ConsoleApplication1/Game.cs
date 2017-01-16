using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    interface IGameStrategy {               //Стратегия
        void InitGame();
        bool IsGameOver();
        void NextTurn();
        void GetTotalResult();
    }

    class Game {
        IGameStrategy gameStrategy;
        public Game(IGameStrategy g) { gameStrategy=g; }
        public void play() {
            gameStrategy.InitGame();
            while (!gameStrategy.IsGameOver()) {
                gameStrategy.NextTurn();
            }
            gameStrategy.GetTotalResult();
        }
        //public void ChangeStrategy(IGameStrategy g) { gameStrategy=g; }
    }
}
