using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public User? User { get; set; }

        [ForeignKey(nameof(User))]
        public int userId { get; set; }
    }
}
