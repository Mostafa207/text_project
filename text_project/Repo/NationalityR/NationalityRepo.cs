using text_project.Data;
using text_project.DTO;
using text_project.Models;

namespace text_project.Repo.NationalityR
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly appdbcontext context;

        public NationalityRepo(appdbcontext context)
        {
            this.context = context;
        }

        public void Add(NationalityDTO dTO)
        {
            var date = new Nationality
            {
                Name = dTO.Name,
            };
            context.Nationalities.Add(date);
            context.SaveChanges();
                
       
        }

        public void Delete(int Id)
        {
            var date= context.Nationalities.FirstOrDefault(x => x.Id == Id);
            if(date != null)
            {
                context.Nationalities.Remove(date);
                context.SaveChanges();
            }
        }
    }
}
