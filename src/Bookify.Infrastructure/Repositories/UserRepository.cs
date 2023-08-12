using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Repositories;

internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}