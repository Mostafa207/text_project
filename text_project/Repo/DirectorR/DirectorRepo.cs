using Microsoft.EntityFrameworkCore;
using text_project.Data;
using text_project.DTO;
using text_project.Models;

namespace text_project.Repo.DirectorR
{
    public class DirectorRepo : IDirectorRepo
    {
        private readonly appdbcontext context;

        public DirectorRepo(appdbcontext context)
        {
            this.context = context;
        }

        public void Add(DirectorDTO dto)
        {
            var date = new Director
            {
                Name = dto.Name,
                Contact = dto.Contact,
                Nationality = new Nationality
                {
                    Name = dto.Nationality.Name
                }
            };
            context.Directors.Add(date);
            context.SaveChanges();
            
        }

        public void Remove(int id)
        {
            var date = context.Directors.Include(d => d.Nationality).FirstOrDefault(x=>x.Id==id);
            if (date != null)
            {
                context.Directors.Remove(date);
                context.SaveChanges();
            }
            
        }

        public void Updata(DirectorDTO dto, int id)
        {
            var date = context.Directors.Include(d => d.Nationality).FirstOrDefault(x => x.Id == id);
             if (date != null)
             {

                date.Name = dto.Name;
                date.Contact = dto.Contact;
                date.Nationality = new Nationality
                {
                    Name = dto.Nationality.Name,
                };
                context.Directors.Update(date);
                context.SaveChanges();
             }

        }
    }
}
