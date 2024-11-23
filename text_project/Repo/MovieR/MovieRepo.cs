using Microsoft.EntityFrameworkCore;
using text_project.Data;
using text_project.DTO;
using text_project.Models;

namespace text_project.Repo.MovieR
{
    public class MovieRepo : IMovieRepo
    {
        private readonly appdbcontext context;

        public MovieRepo(appdbcontext context)
        {
            this.context = context;
        }

        public void Add(MovieDTO dTO)
        {
            var date = new Movie
            {
                Title = dTO.Title,
                date = dTO.date,
                Directors = dTO.Directors.Select(d => new Director
                {
                    Name = d.Name,
                    Contact = d.Contact,
                    Nationality = new Nationality
                    {
                        Name = d.Nationality.Name
                    }
                }).ToList(),
                Category = new Category
                {
                    Name=dTO.Category.Name
                }

            };
            context.Movies.Add(date);
            context.SaveChanges();
            
        }

        public MovieDTO Get(int id)
        {
            var movie = context.Movies.Include(x => x.Category).Include(x => x.Directors).ThenInclude(x => x.Nationality).FirstOrDefault(x=>x.Id==id);
            if (movie!=null)
            {
                MovieDTO dTO = new MovieDTO
                {
                    Title = movie.Title,
                    date = movie.date,
                    Category = new CategoryDTO
                    {
                        Name = movie.Category.Name
                    },
                    Directors= movie.Directors.Select(x=> new DirectorDTO
                    {
                        Name=x.Name,
                        Contact= x.Contact,
                        Nationality=new NationalityDTO
                        {
                            Name=x.Nationality.Name
                        }

                    }).ToList(),
                    
                    
                };
                return (dTO);
                
            }
            return null;


        }

        public IEnumerable<object> GetAll()
        {
            return context.Movies.Include(x => x.Category).Include(x => x.Directors).ThenInclude(x => x.Nationality).Select(x => new
            {
                Title = x.Title,
                date = x.date,
                Directors = x.Directors.Select(d => new 
                {
                    Name = d.Name,
                    Contact = d.Contact,
                    Nationality = new 
                    {
                        Name = d.Nationality.Name
                    }
                }).ToList(),
                Category = new 
                {
                    Name = x.Category.Name
                }

            }).ToList();
        }
    }
}
