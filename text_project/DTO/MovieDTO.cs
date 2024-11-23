using System.ComponentModel.DataAnnotations;
using text_project.Models;

namespace text_project.DTO
{
    public class MovieDTO
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? date { get; set; }
        public List<DirectorDTO>? Directors { get; set; }
        public CategoryDTO? Category { get; set; }
    }
}
