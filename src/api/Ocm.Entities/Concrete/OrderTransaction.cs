using Ocm.Core.Entities;
using Ocm.Entities.Enum;
using System;

namespace Ocm.Entities.Concrete
{
    public class OrderTransaction : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ShipmentId { get; set; }
        public ShippingStatus Status { get; set; }
        public bool IsApprovalRequired { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
    }
}
