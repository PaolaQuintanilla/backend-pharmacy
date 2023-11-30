using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Repositories
{
    public interface ILaboratoryRepository
    {
        public Task<Laboratory> AddLaboratory(Laboratory item);
        public Task<Guid> RemoveLaboratory(Guid id);
        public Task<PagedList<Laboratory>> GetLaboratories(int current, int pageSize);
        public Task<int> getTotal();
    }
}
