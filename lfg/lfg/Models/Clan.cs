using System;
using System.Collections.Generic;

namespace lfg.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public DateTime Created { get; set; }
        public virtual Game Game { get; set; }
        public virtual List<Member> Members { get; set; }
    }
}