using System.Collections.Generic;

namespace lfg.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URLName { get; set; }
        public virtual List<Game> Games { get; set; }

    }
}