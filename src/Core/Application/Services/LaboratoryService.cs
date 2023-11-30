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
        public async Task<Laboratory> AddLaboratoryAsync(Laboratory item)
        {
            return await this.repository.AddLaboratoryAsync(item);
        }

        public async Task<PagedList<Laboratory>> GetLaboratoriesAsync(int current, int pageSize)
        {
            return await this.repository.GetLaboratoriesAsync(current, pageSize);

        }

        public async Task<Guid> RemoveLaboratoryAsync(Guid id)
        {
            return await this.repository.RemoveLaboratoryAsync(id);
        }
    }
}
