using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using Shared.Search.Entities;

namespace Application.Services
{
    public class LaboratoryService : ILaboratoryService
    {
        private readonly ILaboratoryRepository repository;
        public LaboratoryService(ILaboratoryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Laboratory> AddLaboratory(Laboratory item)
        {
            return await this.repository.AddLaboratory(item);
        }

        public async Task<IPagedEnumerable<Laboratory>> GetLaboratories()
        {
            return await this.repository.GetLaboratories();
        }

        public async Task<Laboratory> RemoveLaboratory(Guid id)
        {
            return await this.repository.RemoveLaboratory(id);
        }
    }
}
