using System.ComponentModel.DataAnnotations;

namespace LMS_APIs.Models
{
    public class Publishers
    {
        [Required]
        public int PublisherID { get; set; }

        // Publisher Name, required (not nullable)
        [Required]
        [StringLength(255)]  // Ensures the Name does not exceed 255 characters
        public required string Name { get; set; }

        // Address, optional (nullable)
        [StringLength(int.MaxValue)]  // Optional: Set max length, if needed
        public required string Address { get; set; }

        // Contact Number, optional (nullable)
        [StringLength(15)]  // Ensures the ContactNumber does not exceed 15 characters
        public required string ContactNumber { get; set; }

        // Email, optional (nullable)
        [StringLength(255)]  // Ensures the Email does not exceed 255 characters
        public required string Email { get; set; }
    }
}
