using Microsoft.EntityFrameworkCore;
using text_project.Models;


namespace text_project.Data
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

       

    }
}
