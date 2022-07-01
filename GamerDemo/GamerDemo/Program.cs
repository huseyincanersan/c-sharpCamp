using GamerDemo.Abstract;
using GamerDemo.Adapters;
using GamerDemo.Concrete;
using GamerDemo.Entities;
using System;

namespace GamerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());

            gamerManager.Add(new Gamer() { DateOfBirth = new DateTime(2000, 11, 8), FirstName = "Hüseyin Can", LastName = "Ersan", NationalityId = "10021894038" });

            Gamer gamer = new Gamer();
            gamer.FirstName = "Huseyin can ersan";

            gamerManager.Remove(gamer);
            gamerManager.Update(gamer);

            Game game = new Game();
            game.GameName = "Red Dead Redemption 2";
            game.Id = 3;
            game.Price = 300.0;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);










        }
    }
}
