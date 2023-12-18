using Pharmacy.Domain.Entities;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;

namespace Pharmacy.Infrastructure.Persistences.Repositories
{
    public class WarehouseRepository: GenericRepository<Warehouse>, IWarehouseRepository
    {
        private readonly PharmacyContext _context;
        public WarehouseRepository(PharmacyContext context) : base(context)
        {
            _context = context;
        }
    }
}