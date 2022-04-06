using Microsoft.AspNetCore.Mvc;
using Ocm.Business.Abstract;

namespace Ocm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        #region Fields
        private IShipmentService _shipmentService;
        #endregion

        #region Ctor
        public ShipmentsController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        #endregion

        #region Requests
        //public IActionResult GetList()
        //{
        //    var response = _shipmentService.GetList();
        //    return Ok(response);
        //}
        #endregion
    }
}
