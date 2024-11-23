using System.ComponentModel.DataAnnotations;

namespace text_project.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public Director? Director { get; set; }
    }
}
