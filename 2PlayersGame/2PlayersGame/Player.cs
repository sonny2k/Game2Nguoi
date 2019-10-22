using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PlayersGame
{
    public class Player
    {
        private string Name;
        public Player(string N)
        {
            this.Name = N;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void PickBall(Board game)
        {
            Console.Write("Which group do you choose? ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls will you pick? ");
            int balls = int.Parse(Console.ReadLine());
            game.PickBalls(group, balls);
        }
    }
}
