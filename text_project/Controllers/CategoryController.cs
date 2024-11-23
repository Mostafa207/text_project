using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using text_project.DTO;
using text_project.Repo.CategoryR;

namespace text_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo repo;

        public CategoryController(ICategoryRepo repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public IActionResult Add(CategoryDTO DTO)
        {
            repo.Add(DTO);
            return Created();
        }
        [HttpPut]
        public IActionResult Edit(CategoryDTO DTO,int id)
        {
            repo.Update(DTO,id);
            return Ok();
        }
        
    }
}
