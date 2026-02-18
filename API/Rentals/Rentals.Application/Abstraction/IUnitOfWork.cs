namespace Rentals.Application.Abstraction
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task<bool> SaveChangesAsync();
    }
}
