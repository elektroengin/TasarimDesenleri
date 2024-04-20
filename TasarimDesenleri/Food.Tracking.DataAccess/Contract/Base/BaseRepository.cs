using Food.Tracking.Context.ContextSettings;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Food.Tracking.DataAccess.Contract.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly FoodV2DbContext _dbContext;
        public DbSet<T> Table { get; set; }

        public BaseRepository(FoodV2DbContext dbContext)
        {
            _dbContext = dbContext;
            this.Table = dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            Table.Add(entity);
            Save();
            return entity;
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
            Save();
        }

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(long id)
        {
            return Table.Find(id);
        }

        public IEnumerable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            if (isDesc)
            {
                return Table.OrderByDescending(orderBy);
            }
            else
            {
                return Table.OrderBy(orderBy);
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            Save();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return Table.Where(where);
        }
        
        public T Delete(long id)
        {
            var entity = Table.Find(id);

            if (entity == null)
            {
                return entity;
            }

            Table.Remove(entity);
            Save();
            return entity;
        }
    }
}
