using Microsoft.AspNetCore.Identity;

namespace FP.Data.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set;}
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
