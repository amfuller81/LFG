using System;
using System.Collections.Generic;

namespace lfg.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public ApplicationUser Author { get; set;}
        public bool IsActive { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<Reply> Replies { get; set; }
        
    }
}