using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.Business.Constants;
using Ocm.Business.Mappings.AutoMapper;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Ocm.Business.Concrete
{
    public class OrderTransactionManager : IOrderTransactionService
    {
        #region Fields
        private IOrderTransactionDal _orderTransactionDal;
        #endregion

        #region Ctor
        public OrderTransactionManager(IOrderTransactionDal OrderTransactionDal)
        {
            _orderTransactionDal = OrderTransactionDal;
        }
        #endregion

        #region Methods
        public IDataResult<OrderTransactionDto> CreateTransaction(CreateOrderTransactionDto createOrderTransactionDto)
        {
            var createModel = ObjectMapper.Mapper.Map<CreateOrderTransactionDto, OrderTransaction>(createOrderTransactionDto);

            if (createOrderTransactionDto.CategoryId == 1)
                createModel.ShipmentId = 1;
            else
                createModel.ShipmentId = 2;

            var responseModel = _orderTransactionDal.Add(createModel);
            return new SuccessDataResult<OrderTransactionDto>(ObjectMapper.Mapper.Map<OrderTransaction, OrderTransactionDto>(responseModel), Messages.Success);
        }

        public IResult DeleteTransaction(int id)
        {
            var dataToBeDeleted = _orderTransactionDal.Get(x => x.Id == id);

            if (dataToBeDeleted.CategoryId == 1)
            {
                _orderTransactionDal.Delete(dataToBeDeleted);
                return new SuccessResult(Messages.Success);
            }
            else
                return new ErrorResult(Messages.ConfirmationRequired);
        }

        public IDataResult<List<OrderTransaction>> GetList()
        {
            return new SuccessDataResult<List<OrderTransaction>>(_orderTransactionDal.GetList().ToList());
        }
        #endregion
    }
}
