using System;
using System.Collections.Generic;

namespace lfg.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Reply> Replies { get; set; }
    }
}