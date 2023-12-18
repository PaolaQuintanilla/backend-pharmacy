using AutoMapper;
using Pharmacy.Application.Dtos.User.Request;
using Pharmacy.Domain.Entities;

namespace Pharmacy.Application.Mappers
{
    public class UserMappingsProfile : Profile
    {
        public UserMappingsProfile()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<TokenRequestDto, User>();
        }
    }
}