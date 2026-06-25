using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TripMate.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        // Standard CRUD
        T GetById(string id);
        Task<T> GetByIdAsync(object id);

        // Read Lists
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync(); 


        // Writes
        void Add(T entity);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);

        void IsTracking(T entity);
        Task IsTrackingAsync(T entity);

        void SetTracking(T entity);
        Task SetTrackingAsync(T entity);

        // Hard Delete
        void Delete(object id);
        Task DeleteAsync(object id);

        // Helpers
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string includeProperties = "");

        Task SaveChangesAsync();
    }
}
