using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Repositories
{
    public interface ILaboratoryRepository
    {
        public Task<Laboratory> AddLaboratory(Laboratory item);
        public Task<Laboratory> RemoveLaboratory(Guid id);
        public Task<IPagedEnumerable<Laboratory>> GetLaboratories();
    }
}
