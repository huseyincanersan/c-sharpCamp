using GamerDemo.Abstract;
using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı bilgileri.");
            }
        }
    }
}
