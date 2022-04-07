using Core.Utilities.Results;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;
using System.Collections.Generic;

namespace Ocm.Business.Abstract
{
    public interface IShipmentService
    {
        IDataResult<List<Shipment>> GetList();
        IResult Add(ShipmentDto shipmentDto);
        IResult Update(Shipment shipment);
        IResult Remove(int id);
    }
}
