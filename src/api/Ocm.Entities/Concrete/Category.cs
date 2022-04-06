using Ocm.Core.Entities;
using System;

namespace Ocm.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
