using text_project.DTO;

namespace text_project.Repo.NationalityR
{
    public interface INationalityRepo
    {
        public void Add(NationalityDTO dTO);
        public void Delete(int Id);
    }
}
