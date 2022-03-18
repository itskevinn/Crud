using Domain.Entities.Base;

namespace Domain.Repository
{
    public interface IGenericRepository<T> where T: DomainEntity
    {
       List<T> GetAll();
        Task<T> AddAsync(T entity);
    }
}
