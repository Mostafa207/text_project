using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using text_project.DTO;
using text_project.Repo.CategoryR;
using text_project.Repo.MovieR;

namespace text_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo repo;

        public MovieController(IMovieRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var movie = repo.Get(id);
            return Ok(movie);
        }
        [HttpPost]
        public IActionResult post(MovieDTO dTO)
        {
            repo.Add(dTO);
            return Created();
        }
    }
}
