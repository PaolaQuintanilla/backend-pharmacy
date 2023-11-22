using Domain.Entities;
using Domain.Repositories;
using Persistence.Context;
using Persistence.Entities;
using Shared.Search.Entities;

namespace Persistence.Repositories
{
    public class LaboratoryRepository : ILaboratoryRepository
    { 
        private readonly PharmacydbContext context;

        public LaboratoryRepository( PharmacydbContext context )
        {
            this.context = context;
        }
        public async Task<Laboratory> AddLaboratory(Laboratory item)
        {
            DbLaboratory dblaboratory = new DbLaboratory() { Name = item.Name };   
            var result = await this.context.Laboratories.AddAsync(dblaboratory);

            return item;
        }

        public Task<IPagedEnumerable<Laboratory>> GetLaboratories()
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> RemoveLaboratory(Guid id)
        {
            //await this.context.Laboratories.Remove()
            throw new NotImplementedException();
        }
    }
}
