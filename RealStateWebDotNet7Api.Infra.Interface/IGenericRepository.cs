using RealStateWebDotNet7Api.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.Infra.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        #region Sync Methods
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        T Get(int id);
        IEnumerable<T> GetAll();
        #endregion

        IEnumerable<T> GetAllPaginated( int pageNum , int pageSize);
        int CountT();

        #region Aync Methods
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);

        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllPaginatedAsync(int pageNum, int pageSize);
        int CountTAsync();
        #endregion
    }
}
