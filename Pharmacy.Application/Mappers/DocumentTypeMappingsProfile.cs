using AutoMapper;
using Pharmacy.Application.Dtos.DocumentType.Response;
using Pharmacy.Domain.Entities;

namespace Pharmacy.Application.Mappers
{
    public class DocumentTypeMappingsProfile : Profile
    {
        public DocumentTypeMappingsProfile()
        {
            CreateMap<DocumentType, DocumentTypeResponseDto>()
                .ForMember(x => x.DocumentTypeId, x => x.MapFrom(y => y.Id))
                .ReverseMap();
        }
    }
}