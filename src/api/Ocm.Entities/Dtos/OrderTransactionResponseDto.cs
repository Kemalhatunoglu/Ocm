using Ocm.Entities.Enum;

namespace Ocm.Entities.Dtos
{
    public class OrderTransactionDto
    {
        public int CategoryId { get; set; }
        public int ShipmentId { get; set; }
        public ShippingStatus Status { get; set; }
    }
}
