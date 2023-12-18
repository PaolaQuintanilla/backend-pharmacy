using Pharmacy.Domain.Entities;
using Pharmacy.Utilities.Search.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Infrastructure.Persistences.Interfaces
{
    public interface ILaboratoryRepository
    {
        Task<Laboratory> AddLaboratoryAsync(Laboratory item);
        Task<Guid> RemoveLaboratoryAsync(Guid id);
        Task<PagedList<Laboratory>> GetLaboratoriesAsync(int current, int pageSize); //pagination
    }
}
