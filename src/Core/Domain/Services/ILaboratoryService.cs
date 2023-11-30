using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Services
{
    public interface ILaboratoryService
    {
        public Task<Laboratory> AddLaboratoryAsync(Laboratory item);
        public Task<Guid> RemoveLaboratoryAsync(Guid id);
        public Task<PagedList<Laboratory>> GetLaboratoriesAsync(int current, int pageSize); //pagination

    }
}
