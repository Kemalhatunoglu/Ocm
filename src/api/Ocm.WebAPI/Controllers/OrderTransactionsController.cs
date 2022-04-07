using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Ocm.Business.Abstract;
using Ocm.Entities.Dtos;
using System;

namespace Ocm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderTransactionsController : ControllerBase
    {
        #region Fields
        private IOrderTransactionService _orderTransactionService;
        private IDistributedCache _distributedCache;
        #endregion

        #region Ctor
        public OrderTransactionsController(IOrderTransactionService orderTransactionService, IDistributedCache distributedCache)
        {
            _orderTransactionService = orderTransactionService;
            _distributedCache = distributedCache;
        }
        #endregion

        #region Request
        [HttpPost]
        public IActionResult AddOrderTransactions(CreateOrderTransactionDto createOrderTransactionDto)
        {
            var result = _orderTransactionService.CreateTransaction(createOrderTransactionDto);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = _orderTransactionService.GetList();
            if (result.Success)
            {
                _distributedCache.SetString("list", result.Data.ToString(), new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(1200),
                    SlidingExpiration = TimeSpan.FromMinutes(10)
                });
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _orderTransactionService.DeleteTransaction(id);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);
        }
        #endregion
    }
}
