using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Pharmacy.Domain.Entities;
using Pharmacy.Infrastructure.FileStorage;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;
using System.Data;

namespace Pharmacy.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PharmacyContext _context;
        public IUserRepository _user = null!;
        public IGenericRepository<Category> _category = null!;
        public IGenericRepository<Provider> _provider = null!;
        public IGenericRepository<DocumentType> _documentType = null!;
        public IWarehouseRepository _warehouse = null!;
        public IGenericRepository<Product> _product = null!;
        public IProductStockRepository _productStock = null!;

        public UnitOfWork(PharmacyContext context, IConfiguration configuration)
        {
            _context = context;
        }

        public IGenericRepository<Category> Category => _category ?? new GenericRepository<Category>(_context);
        public IGenericRepository<Provider> Provider => _provider ?? new GenericRepository<Provider>(_context);
        public IGenericRepository<DocumentType> DocumentType => _documentType ?? new GenericRepository<DocumentType>(_context);
        public IUserRepository User => _user ?? new UserRepository(_context);
        public IWarehouseRepository Warehouse => _warehouse ?? new WarehouseRepository(_context);
        public IGenericRepository<Product> Product => _product ?? new GenericRepository<Product>(_context);
        public IProductStockRepository ProductStock => _productStock ?? new ProductStockRepository(_context);

        public IDbTransaction BeginTransaction()
        {
            var transaction = _context.Database.BeginTransaction();
            return transaction.GetDbTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}