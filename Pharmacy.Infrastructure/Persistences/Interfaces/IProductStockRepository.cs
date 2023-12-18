using Pharmacy.Domain.Entities;

namespace Pharmacy.Infrastructure.Persistences.Interfaces
{
    public interface IProductStockRepository
    {
        Task<bool> RegisterProductStock(ProductStock productStock);
    }
}