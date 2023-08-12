using Bookify.Domain.Apartments;

namespace Bookify.Infrastructure.Repositories;

internal sealed class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}