using GamerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string  GameName { get; set; }
        public double Price { get; set; }
    }
}
