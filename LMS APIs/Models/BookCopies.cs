using System.ComponentModel.DataAnnotations;

namespace LMS_APIs.Models
{
    public class BookCopies
    {
        [Key]
        public int BookCopyID { get; set; }

        [Required]
        public required int BookID { get; set; }

        [Required]
        public required int BranchID { get; set; }

        [Required]
        public required int CopyNumber { get; set; }

        public string? Status { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? LastUpdatedBy { get; set; }

        public DateTime? LastUpdatedOn { get; set; }
    }

}
