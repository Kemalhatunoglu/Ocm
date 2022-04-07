using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ocm.Business.Abstract;
using Ocm.Entities.Dtos;

namespace Ocm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region Fields
        private ICategoryService _categoryService;
        #endregion

        #region Ctor
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        #region Requests
        [HttpPost]
        public IActionResult Add(CategoryDto categoryDto)
        {
            var result = _categoryService.Add(categoryDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
    }
}
