using System.ComponentModel.DataAnnotations;

namespace MultiUser_Portfolio.Models
{
    public class About
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}