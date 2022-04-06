using Ocm.Core.Entities;

namespace Ocm.Entities.Concrete
{
    public class Shipment : IEntity
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public string FirmPhone { get; set; }
        public string FirmInformation { get; set; }
    }
}
