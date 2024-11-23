using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using text_project.DTO;
using text_project.Repo.CategoryR;
using text_project.Repo.DirectorR;

namespace text_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepo repo;

        public DirectorController(IDirectorRepo repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public IActionResult POST(DirectorDTO dTO)
        {
            repo.Add(dTO);
            return Created();
        }
        [HttpPut]
        public IActionResult PUT(DirectorDTO dTO,int Id)
        {
            repo.Updata(dTO, Id);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DELETE(int Id)
        {
            repo.Remove(Id);
            return Ok();
        }

    }
}
