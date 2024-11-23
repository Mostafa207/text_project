using System.ComponentModel.DataAnnotations;

namespace text_project.DTO
{
    public class NationalityDTO
    {
        [Required]
        public string? Name { get; set; }
    }
}
