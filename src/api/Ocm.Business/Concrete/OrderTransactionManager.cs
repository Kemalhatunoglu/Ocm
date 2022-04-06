using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Ocm.Business.Concrete
{
    public class OrderTransactionManager : IOrderTransactionService
    {
        private IOrderTransactionDal _orderTransactionDal;

        public OrderTransactionManager(IOrderTransactionDal OrderTransactionDal)
        {
            _orderTransactionDal = OrderTransactionDal;
        }

        public IResult CreateTransaction(OrderTransaction orderTransaction)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<OrderTransaction>> GetList()
        {
            return new SuccessDataResult<List<OrderTransaction>>(_orderTransactionDal.GetList().ToList());
        }
    }
}
