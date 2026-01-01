using System.ComponentModel.DataAnnotations;

namespace MultiUser_Portfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Category { get; set; } = "Other"; // e.g., "Language", "Framework", "Tool"
        
        // Bootstrap Icon class (e.g., "bi-code-slash", "bi-database")
        public string IconClass { get; set; } = "bi-code-slash";
    }
}