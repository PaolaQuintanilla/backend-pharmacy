using Pharmacy.Domain.Entities;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;

namespace Pharmacy.Infrastructure.Persistences.Repositories
{
    public class ProductStockRepository : IProductStockRepository
    {
        private readonly PharmacyContext _context;

        public ProductStockRepository(PharmacyContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterProductStock(ProductStock productStock)
        {
            await _context.AddAsync(productStock);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }
    }
}