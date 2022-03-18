using Domain.Entities.Base;
using Domain.Repository;

namespace Infrastructure.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : DomainEntity
    {
        private CrudContext _crudContext;
        public GenericRepository(CrudContext crudContext)
        {
            _crudContext = crudContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            _ = entity ?? throw new ArgumentNullException(nameof(entity));
            _crudContext.Set<T>().Add(entity);
            await CommitAsync();
            return entity;
        }

        public List<T> GetAll()
        {
            IQueryable<T> query = _crudContext.Set<T>();
            return query.ToList();
        }

        public async Task CommitAsync()
        {
           await _crudContext.SaveChangesAsync();
        }

      
    }
}
