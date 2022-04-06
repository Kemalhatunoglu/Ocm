using Ocm.Core.DataAccess.EntityFramework;
using Ocm.DataAccess.Abstract;
using Ocm.DataAccess.Context;
using Ocm.Entities.Concrete;

namespace Ocm.DataAccess.Concrete
{
    public class EfShipmentDal : EfEntityRepositoryBase<Shipment, OcmContext>, IShipmentDal
    {
    }
}
