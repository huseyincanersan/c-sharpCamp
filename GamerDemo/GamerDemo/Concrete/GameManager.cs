using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo.Entities
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" eklendi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" guncellendi");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " silindi");
        }
    }
}
