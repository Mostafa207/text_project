using text_project.DTO;

namespace text_project.Repo.DirectorR
{
    public interface IDirectorRepo
    {
        public void Add(DirectorDTO dto);
        public void Updata(DirectorDTO dto,int id);
        public void Remove(int id);
    }
}
