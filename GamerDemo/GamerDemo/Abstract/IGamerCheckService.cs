using GamerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfPerson(Gamer gamer);
    }
}
