using System.ComponentModel.DataAnnotations;

namespace MultiUser_Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string? ProjectLink { get; set; }
    }
}