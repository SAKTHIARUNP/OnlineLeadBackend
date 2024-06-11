using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLeadMgmt.Models
{
    public class Lead
    {
        [Key]
        public int LeadId { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="MobileNo is Required")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string InterestedProducts { get; set; }
        
      
        public string Password { get; set; }
        
      

    }
}
