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

        public async Task<PagedList<Laboratory>> GetLaboratories(int current, int pageSize)
        {
            return await this.repository.GetLaboratories(current, pageSize);

        }

        public async Task<Guid> RemoveLaboratory(Guid id)
        {
            return await this.repository.RemoveLaboratory(id);
        }
    }
}
