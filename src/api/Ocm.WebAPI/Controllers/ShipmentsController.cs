using Microsoft.AspNetCore.Mvc;
using Ocm.Business.Abstract;
using Ocm.Entities.Dtos;

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
        [HttpGet]
        public IActionResult GetList()
        {
            var result = _shipmentService.GetList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(ShipmentDto shipmentDto)
        {
            var result = _shipmentService.Add(shipmentDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _shipmentService.Remove(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
    }
}
