using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Services
{
    public interface ILaboratoryService
    {
        public Task<Laboratory> AddLaboratory(Laboratory item);
        public Task<Guid> RemoveLaboratory(Guid id);
        public Task<PagedList<Laboratory>> GetLaboratories(int current, int pageSize); //pagination

    }
}
