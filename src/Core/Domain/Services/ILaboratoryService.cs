using Domain.Entities;
using Shared.Search.Entities;

namespace Domain.Services
{
    public interface ILaboratoryService
    {
        public Task<Laboratory> AddLaboratory(Laboratory item);
        public Task<Laboratory> RemoveLaboratory(Guid id);
        public Task<IPagedEnumerable<Laboratory>> GetLaboratories(); //pagination

    }
}
