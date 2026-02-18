using Rentals.Application.Abstraction;
using Rentals.Infrastructure.Context;

namespace Rentals.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_databaseContext);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _databaseContext.SaveChangesAsync() > 0;
        }
    }
}
