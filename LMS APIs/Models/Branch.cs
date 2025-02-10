using System.ComponentModel.DataAnnotations;

namespace LMS_APIs.Models
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [Required]
        [MaxLength(255)]
        public  string Name { get; set; }

        public string? Address { get; set; }

        [MaxLength(15)]
        public string? ContactNumber { get; set; }

       
        
    }
}
