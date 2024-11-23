using text_project.DTO;

namespace text_project.Repo.MovieR
{
    public interface IMovieRepo
    {
        IEnumerable<object> GetAll();
        public MovieDTO Get(int id);
        public void Add(MovieDTO dTO);
         
    }
}
