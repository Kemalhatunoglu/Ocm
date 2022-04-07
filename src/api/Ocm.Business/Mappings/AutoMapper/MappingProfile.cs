using AutoMapper;
using Ocm.Entities.Concrete;
using Ocm.Entities.Dtos;

namespace Ocm.Business.Mappings.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderTransaction, CreateOrderTransactionDto>().ReverseMap();
            CreateMap<OrderTransaction, OrderTransactionDto>().ReverseMap();

            CreateMap<Shipment, ShipmentDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
