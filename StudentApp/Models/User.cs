using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public required string Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
