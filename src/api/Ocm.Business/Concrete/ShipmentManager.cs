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
    public class ShipmentManager : IShipmentService
    {
        #region Fields
        private IShipmentDal _shipmentDal;
        #endregion

        #region Ctor
        public ShipmentManager(IShipmentDal ShipmentDal)
        {
            _shipmentDal = ShipmentDal;
        }
        #endregion

        #region Methods
        public IResult Add(Shipment shipment)
        {
            _shipmentDal.Add(shipment);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Shipment>> GetList()
        {
            return new SuccessDataResult<List<Shipment>>(_shipmentDal.GetList().ToList());
        }

        public IResult Remove(Shipment shipment)
        {
            _shipmentDal.Delete(shipment);
            return new SuccessResult(Messages.Success);
        }

        public IResult Update(Shipment shipment)
        {
            _shipmentDal.Update(shipment);
            return new SuccessResult(Messages.Success);
        }
        #endregion
    }
}
