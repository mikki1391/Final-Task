using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGame // это интерфейс
{
    interface IGame
    {
        bool play();
        
    }
    public string get_game_name()
    {
        return this.name;
    }

}
