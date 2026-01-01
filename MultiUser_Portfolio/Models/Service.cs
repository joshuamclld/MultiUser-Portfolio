using System.ComponentModel.DataAnnotations;

namespace MultiUser_Portfolio.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }
    }
}
