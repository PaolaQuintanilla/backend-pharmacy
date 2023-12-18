using AutoMapper;
using Pharmacy.Application.Dtos.Provider.Request;
using Pharmacy.Application.Dtos.Provider.Response;
using Pharmacy.Domain.Entities;
using Pharmacy.Utilities.Static;

namespace Pharmacy.Application.Mappers
{
    public class ProviderMappingsProfile : Profile
    {
        public ProviderMappingsProfile()
        {
            CreateMap<Provider, ProviderResponseDto>()
                .ForMember(x => x.ProviderId, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.DocumentType, x => x.MapFrom(y => y.DocumentType.Abbreviation))
                .ForMember(x => x.StateProvider, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<Provider, ProviderByIdResponseDto>()
                .ForMember(x => x.ProviderId, x => x.MapFrom(y => y.Id))
                .ReverseMap();

            CreateMap<ProviderRequestDto, Provider>();
        }
    }
}