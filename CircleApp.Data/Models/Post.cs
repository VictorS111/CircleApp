using System.ComponentModel.DataAnnotations;

namespace CircleApp.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public string? ImageUrl { get; set; }

        public int NrOfReports { get; set; } 

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        // Foreign key for User
        public int UserId { get; set; }

        // Navigation property for User
        public User User { get; set; }
    }
}
