using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayersGame
{
    public class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Thanh");
            P2 = new Player("Khanh");
            Game = new Board(3, 4, 6);
        }
        public void PlayGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine(P1.GetName() + "'s turn");
                P1.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " is lost !");
                    Console.WriteLine(P2.GetName() + " is a champion !");
                    break;
                }
                Console.WriteLine(P2.GetName() + "'s turn");
                P2.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " is lost !");
                    Console.WriteLine(P1.GetName() + " is a champion !");
                    break;
                }
            }
        }
    }
}
