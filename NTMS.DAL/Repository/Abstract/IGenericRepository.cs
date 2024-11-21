using System.Linq.Expressions;

namespace NTMS.DAL.Repository.Abstract
{
    public interface IGenericRepository<T>where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<T> Create(T model);
        Task<bool> Edit(T model);
        Task<bool> Delete(T model);
        Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> filter=null );


    }
}
