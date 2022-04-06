using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ocm.Business.Abstract;

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
        //public IActionResult GetList()
        //{
        //    var response = _categoryService.GetList();
        //    return Ok(response);
        //}
        #endregion
    }
}
