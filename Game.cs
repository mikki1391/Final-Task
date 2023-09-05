using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGame
{
    class Game: IGame
    {
        private string name;

        public string get_game_name()
        {
            return this.name;
        }

        public bool play()
        {
            Console.WriteLine($"{this.name} is begin");
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            //if (result == 0) throw new GameExeption("Sorry!");
            if (result % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
