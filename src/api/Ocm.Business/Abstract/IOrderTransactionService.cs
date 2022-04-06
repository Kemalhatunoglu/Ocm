using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface IOrderTransactionService
    {
        IDataResult<List<OrderTransaction>> GetList();
        IResult CreateTransaction(OrderTransaction orderTransaction);
    }
}
