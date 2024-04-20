using System.Linq.Expressions;

namespace Food.Tracking.DataAccess.Contract.Base
{
    //T : Entity
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(long id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Delete(long id);
        IQueryable<T> Where(Expression<Func<T, bool>> where);
        IEnumerable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc);
        void Save();
    }
}
