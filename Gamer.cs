using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGame
{
    /*
    реализовать электронную очередь, в очередь добавляются игры
(класс QueueGame);
    играть могут только зарегистрированные игроки;
у каждого игрока есть:
идентификатор, 
логин, 
количество сыгранных игр, 
список игр и последний результат(победа или поражение)
игрок по очереди играет в игры из очереди;
    результат игры изменяет состояние игрока.
    Вывести рейтинг игроков по количеству сыгранных игр
   Вывести рейтинг игроков  по количеству побед
    */
    class Gamer
    {
        private string gamer_name;
        private QueueGame gameQuer;
        private int ID;
        private Dictionary<string, int[]> gameResult;
        public static int gamer_counter = 0;

        public Gamer(string gamer_name)
        {
            this.gamer_name = gamer_name;
            this.gameQuer = new QueueGame();
            this.ID = ++gamer_counter;
            this.gameResult = new Dictionary<string, int[]> ;
        }
        public void UpdateStatistic(string game_name, bool result)
        {
            if (result) gameResult.Add(game.get_game_name(), new int[] { 1, 0 });
            else gameResult.Add(game.get_game_name(), new int[] { 0, 1 });
        }
        public void Play()
        {
            IGame game = this.gameQuer.Del();
            bool result = game.play();
            UpdateStatistic(game.get_game_name(), result);
        }

        public string ShowGameQuer() => this.gameQuer.ShowListGame();

        public string ShowResults()
        {
            string strresults = "";
            foreach (var game in gameResult)
            {
                strresults += $"{game.Key} побед: {game.Value[0]}, поражений: {game.Value[1]}.";
            }
            return strresults;
        }
        public void AddGame(IGame game)
        {
            this.gameQuer.Add(game);
        }
    }
}

