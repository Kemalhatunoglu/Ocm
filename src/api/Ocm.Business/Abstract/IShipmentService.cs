using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface IShipmentService
    {
        IDataResult<List<Shipment>> GetList();
        IResult Add(Shipment shipment);
        IResult Update(Shipment shipment);
        IResult Remove(Shipment shipment);
    }
}
