using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayersGame
{
    public class Board
    {
        int G1;
        int G2;
        int G3;

        public Board(int g1, int g2, int g3)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;
        }

        public void PickBalls(int group, int balls)
        {
            switch (group)
            {
                case 1:
                    G1 -= balls;
                    break;
                case 2:
                    G2 -= balls;
                    break;
                case 3:
                    G3 -= balls;
                    break;
            }
        }

        public void PrintGame()
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < G1; i++)
                Console.Write("0 ");
            Console.WriteLine();
            Console.Write("Group 2: ");
            for (int i = 0; i < G2; i++)
                Console.Write("0 ");
            Console.WriteLine();
            Console.Write("Group 3: ");
            for (int i = 0; i < G3; i++)
                Console.Write("0 ");
            Console.WriteLine();
        }

        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
                return true;
           else
                return false;
        }
    }

}
