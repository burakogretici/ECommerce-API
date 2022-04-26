using System.Linq.Expressions;

namespace ECommerceAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> filter, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T,bool>> filter, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
     


    }
}
