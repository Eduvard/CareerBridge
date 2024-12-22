using System.ComponentModel.DataAnnotations;

namespace CareerBridge.Data
{
    public class CareerArticle
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        public DateTime DatePublished { get; set; } = DateTime.UtcNow;
    }
}