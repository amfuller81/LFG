using System.Collections.Generic;

namespace lfg.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public ApplicationUser Author { get; set; }
        public virtual Post Post { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}