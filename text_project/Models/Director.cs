using System.ComponentModel.DataAnnotations;

namespace text_project.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Contact { get; set; }

        public List<Movie>? Movies { get; set; }
        public int? NationalityId { get; set; }
       
        public Nationality ?Nationality { get; set; }




    }
}
