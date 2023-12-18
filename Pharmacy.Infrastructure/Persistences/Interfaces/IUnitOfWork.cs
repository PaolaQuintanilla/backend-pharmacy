using Pharmacy.Domain.Entities;
using System.Data;

namespace Pharmacy.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaración o matricula de nuestra interfaces a nivel de repository
        IGenericRepository<Category> Category { get; }
        IGenericRepository<Provider> Provider { get; }
        IGenericRepository<DocumentType> DocumentType { get; }
        IUserRepository User { get; }
        IWarehouseRepository Warehouse { get; }
        IGenericRepository<Product> Product { get; }
        IProductStockRepository ProductStock { get; }
        void SaveChanges();
        Task SaveChangesAsync();
        IDbTransaction BeginTransaction();
    }
}