namespace lfg.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public virtual ApplicationUser User { get; set; }
        
    }
}