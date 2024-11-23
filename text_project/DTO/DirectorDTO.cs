using System.ComponentModel.DataAnnotations;
using text_project.Models;

namespace text_project.DTO
{
    public class DirectorDTO
    {
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Contact { get; set; }

        public NationalityDTO? Nationality { get; set; }
    }
}
