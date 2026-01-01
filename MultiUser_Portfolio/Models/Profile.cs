using System.ComponentModel.DataAnnotations;

namespace MultiUser_Portfolio.Models
{
    public class Profile
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string ShortBio { get; set; } = string.Empty;

        public string? ProfilePictureUrl { get; set; }
        
        public string? CVUrl { get; set; }
    }
}