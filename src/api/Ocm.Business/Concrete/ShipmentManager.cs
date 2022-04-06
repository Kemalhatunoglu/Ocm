using Core.Utilities.Results;
using Ocm.Business.Abstract;
using Ocm.DataAccess.Abstract;
using Ocm.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Ocm.Business.Concrete
{
    public class ShipmentManager : IShipmentService
    {
        private IShipmentDal _shipmentDal;

        public ShipmentManager(IShipmentDal ShipmentDal)
        {
            _shipmentDal = ShipmentDal;
        }

        public IDataResult<List<Shipment>> GetList()
        {
            return new SuccessDataResult<List<Shipment>>(_shipmentDal.GetList().ToList());
        }
    }
}
