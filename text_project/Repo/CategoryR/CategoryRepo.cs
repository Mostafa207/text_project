using text_project.Data;
using text_project.DTO;
using text_project.Models;

namespace text_project.Repo.CategoryR
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly appdbcontext context;

        public CategoryRepo(appdbcontext context)
        {
            this.context = context;
        }

        public void Add(CategoryDTO dTO)
        {
            var date = new Category
            {
                Name = dTO.Name,
            };
            context.Categories.Add(date);
            context.SaveChanges();
            
        }

        public void Update(CategoryDTO dTO, int id)
        {
            var date = context.Categories.FirstOrDefault(c => c.Id == id);
             if(date != null) {

                date.Name = dTO.Name;
                context.Categories.Update(date);
                context.SaveChanges();
             };


        }
    }
}
