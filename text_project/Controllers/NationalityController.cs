using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using text_project.DTO;
using text_project.Repo.CategoryR;
using text_project.Repo.NationalityR;

namespace text_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepo repo;

        public NationalityController(INationalityRepo repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public IActionResult Post(NationalityDTO dTO)
        {
            repo.Add(dTO);
            return Created();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return Ok();
        }
    }
}
