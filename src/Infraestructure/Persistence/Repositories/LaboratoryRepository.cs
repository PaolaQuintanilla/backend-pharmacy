using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Entities;
using Shared.Search.Entities;

namespace Persistence.Repositories
{
    public class LaboratoryRepository : ILaboratoryRepository
    { 
        private readonly PharmacydbContext context;
        private readonly IMapper _mapper;

        public LaboratoryRepository( PharmacydbContext context, IMapper mapper )
        {
            this.context = context;
            this._mapper = mapper;
        }
        public async Task<Laboratory> AddLaboratoryAsync(Laboratory item)
        {
            DbLaboratory dblaboratory = new DbLaboratory() { Name = item.Name, Id = item.Id  };   
            var result = await this.context.Laboratories.AddAsync(dblaboratory);
            await this.context.SaveChangesAsync();

            return item;
        }

        public async Task<PagedList<Laboratory>> GetLaboratoriesAsync(int page, int pageSize)
        {
            int total = await getTotalAsync();
            var result = new PagedList<Laboratory>(total, page, pageSize);
            var laboratoryList = await this.context.Laboratories
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();

            result.Data = this._mapper.Map<List<Laboratory>>(laboratoryList);
            return result;
        }

        public async Task<int> getTotalAsync()
        {
            return await this.context.Laboratories.CountAsync();
        }

        public async Task<Guid> RemoveLaboratoryAsync(Guid id)
        {
            var entity = this.context.Laboratories.Single<DbLaboratory>(x => x.Id == id);
            this.context.Remove<DbLaboratory>(entity);
            await this.context.SaveChangesAsync();
            return id;
        }
    }
}
