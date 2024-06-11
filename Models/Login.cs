using System.ComponentModel.DataAnnotations;

namespace OnlineLeadMgmt.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Role {  get; set; }
        
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
