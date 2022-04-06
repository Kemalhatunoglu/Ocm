using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface IOrderTransactionService
    {
        IDataResult<List<OrderTransaction>> GetList();
        IDataResult<OrderTransactionDto> CreateTransaction(CreateOrderTransactionDto createOrderTransactionDto);
        IResult DeleteTransaction(int id);
    }
}
