using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGame
{
    class QueueGame
    {
        List<IGame> listGames = new List<IGame>();
        public void Add(IGame game)
        {
            listGames.Add(game);
        }
        public IGame Del()
        {
            IGame game = listGames[0];
            listGames.RemoveAt(0);
            return game;
        }
        public string ShowListGame()
        {
            string strgame = "";
            foreach (Game game in listGames)strgame += game.get_game_name();
            return strgame;
        }


    }
}
