using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealStateWebDotNet7Api.Domain.Entity;

namespace RealStateWebDotNet7Api.Domain.Interface
{
    public interface IResidentsDomain
    {
        #region Sync Methods
        bool Insert(Residents resident);
        bool Update(Residents resident);
        bool Delete(Residents resident);

        Residents Get(int id);
        IEnumerable<Residents> GetAll();
        #endregion

        IEnumerable<Residents> GetAllPaginated(int pageNum, int pageSize);
        int CountT();


        #region Aync Methods
        Task<bool> InsertAsync(Residents resident);
        Task<bool> UpdateAsync(Residents resident);
        Task<bool> DeleteAsync(Residents resident);

        Task<Residents> GetAsync(int id);
        Task<IEnumerable<Residents>> GetAllAsync();
        #endregion

    }
}
