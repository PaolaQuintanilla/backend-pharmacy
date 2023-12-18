using Microsoft.EntityFrameworkCore;
using Pharmacy.Domain.Entities;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;

namespace Pharmacy.Infrastructure.Persistences.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly PharmacyContext _context;
        public UserRepository(PharmacyContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> UserByEmail(string email)
        {
            var user = await _context.Users.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email!.Equals(email));
            return user!;
        }
    }
}