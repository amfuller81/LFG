using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lfg.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string URLName { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Platform> Platforms { get; set; }
        public virtual List<Clan> Clans { get; set; }

    }
}