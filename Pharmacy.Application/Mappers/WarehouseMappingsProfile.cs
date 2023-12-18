using AutoMapper;
using Pharmacy.Application.Dtos.Warehouse.Request;
using Pharmacy.Application.Dtos.Warehouse.Response;
using Pharmacy.Domain.Entities;
using Pharmacy.Utilities.Static;

namespace Pharmacy.Application.Mappers
{
    public class WarehouseMappingsProfile : Profile
    {
        public WarehouseMappingsProfile()
        {
            CreateMap<Warehouse, WarehouseResponseDto>()
               .ForMember(x => x.WarehouseId, x => x.MapFrom(y => y.Id))
               .ForMember(x => x.StateWarehouse, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo"))
               .ReverseMap();

            CreateMap<Warehouse, WarehouseByIdResponseDto>()
                .ForMember(x => x.WarehouseId, x => x.MapFrom(y => y.Id))
                .ReverseMap();

            CreateMap<WarehouseRequestDto, Warehouse>();
        }
    }
}