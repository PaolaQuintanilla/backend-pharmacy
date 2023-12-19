using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Domain.Entities;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;
using Pharmacy.Utilities.Search.Entities;

namespace Pharmacy.Infrastructure.Persistences.Repositories
{
    public class LaboratoryRepository : ILaboratoryRepository
    {
        private readonly PharmacyContext _context;
        private readonly IMapper _mapper;
        public LaboratoryRepository(PharmacyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Laboratory> AddLaboratoryAsync(Laboratory item)
        {
            Laboratory dblaboratory = new Laboratory() { Name = item.Name, Id = item.Id };
            var result = await this._context.Laboratories.AddAsync(dblaboratory);
            await this._context.SaveChangesAsync();

            return item;
        }

        public async Task<PagedList<Laboratory>> GetLaboratoriesAsync(int page, int pageSize)
        {
            int total = await getTotalAsync();
            var result = new PagedList<Laboratory>(total, page, pageSize);
            var laboratoryList = await this._context.Laboratories
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();

            result.Data = this._mapper.Map<List<Laboratory>>(laboratoryList);
            return result;
        }
        public async Task<int> getTotalAsync()
        {
            return await this._context.Laboratories.CountAsync();
        }

        public Task<Guid> RemoveLaboratoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
