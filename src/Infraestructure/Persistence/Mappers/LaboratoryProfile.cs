using AutoMapper;
using Domain.Entities;
using Persistence.Entities;

namespace Persistence.Mappers
{
    public class DbLaboratoryProfile : Profile
    {
        public DbLaboratoryProfile()
        {
            this.CreateMap<DbLaboratory, Laboratory>();
            //.ForMember(dblab => dblab.Id, lab => lab.MapFrom())
            this.CreateMap<Laboratory, DbLaboratory>();
        }
    }
}
