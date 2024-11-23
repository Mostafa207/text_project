using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace text_project.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ?date { get; set; }
        public List<Director> ?Directors { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }



    }
}
