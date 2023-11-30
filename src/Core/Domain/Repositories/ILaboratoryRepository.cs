using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Repositories
{
    public interface ILaboratoryRepository
    {
        public Task<Laboratory> AddLaboratoryAsync(Laboratory item);
        public Task<Guid> RemoveLaboratoryAsync(Guid id);
        public Task<PagedList<Laboratory>> GetLaboratoriesAsync(int current, int pageSize);
        public Task<int> getTotalAsync();
    }
}
