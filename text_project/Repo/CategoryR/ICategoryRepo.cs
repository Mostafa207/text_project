using text_project.DTO;

namespace text_project.Repo.CategoryR
{
    public interface ICategoryRepo
    {
        public void Add(CategoryDTO dTO);

        public void Update(CategoryDTO dTO,int id );
    }
}
