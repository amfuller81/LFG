using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lfg.Models
{
    public class GamesAndPlatforms
    {
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Platform> Platforms { get; set; }
    }
    public class CreateGame
    {
        public virtual Game Game { get; set; }
        public virtual ICollection<Platform> Platforms { get; set; }
    }
    
}