using Pharmacy.Domain.Entities;

namespace Pharmacy.Infrastructure.Persistences.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> UserByEmail(string email);
    }
}